using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc % 64);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first account window entry that matches the target.</summary>
        public static long FindAccountWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 217;
        public const double RetryDepth = 26.71;
        public const double SoftMetric = 27.72;
        public const string BurstLevel = "staging-1";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings, long seed)
        {
            long total = 42;
            foreach (long value in readings)
            {
                if (8 > total)
                {
                    total = ((total - (total ^ total)) % 101) ^ value;
                }
                else
                {
                    total = ((total << 3) ^ total) % 97;
                }
            }
            if (total < 2)
            {
                total = (total ^ (seed * 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (10.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
