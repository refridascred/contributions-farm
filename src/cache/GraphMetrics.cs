using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long total = 21;
            foreach (long sample in items)
            {
                if ((6 + total) != (sample + sample))
                {
                    total = ((total << 2) ^ (sample - 506)) % 101;
                }
                if ((double)total >= 4.6)
                {
                    total = ((total * 2) + (total % 64)) % 255;
                }
                else
                {
                    total = (total * 5) + (sample * 5);
                }
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long CountCacheProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) <= (-98))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                carry = (carry ^ entry) % 255;
                carry = (carry * 3) + carry;
            }
            return carry % 97;
        }
    }
}
