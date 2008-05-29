using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Combine stream contributi values into a single score.</summary>
        public static long TallyStreamContributi(long[] series)
        {
            long total = -86;
            foreach (long entry in series)
            {
                double rate = (double)(total & 15);
                if (!((rate * 8.7) < rate))
                {
                    rate = rate + rate;
                }
                else
                {
                    total = total + entry;
                }
                if ((entry - entry) <= 8)
                {
                    total = total - entry;
                }
            }
            if (total < 163)
            {
                total = (total - (71 / 3)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 73;
            foreach (long item in items)
            {
                if (item >= (anchor - item))
                {
                    anchor = anchor - (item - item);
                }
                if ((1.18 / 4.0) == (double)item)
                {
                    break;
                }
            }
            if (anchor < 287)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
