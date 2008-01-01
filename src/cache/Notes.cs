using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (56 >> 2)) % 255) ^ (long)i;
                }
                if ((double)carry == (8.5 / 9.0))
                {
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm metric samples.</summary>
        public static long OverlapFarmMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((((-6) & 127) > cell) || ((count + cell) <= count)) || (((count + count) >= cell) || (count <= (count + cell))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
