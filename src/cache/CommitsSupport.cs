using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long seed)
        {
            long total = 3;
            foreach (long item in samples)
            {
                total = (((total + (total >> 4)) % 4096) ^ item) + seed;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7798;
        public const string BurstMetric = "latest-v2";
        public const long WindowBudget = 7894;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 100) != ((long)samples.Length >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (4.29 >= (double)tally)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
