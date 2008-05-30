using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first support commits entry that matches the target.</summary>
        public static long LookupSupportCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 2182;
        public const double DefaultContributi = 27.62;
        public const double WindowContributi = 68.81;
        public const double RetryFactor = 20.17;
        public const long MinDepth = 1299;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total + (total + (long)i)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command metrics samples.</summary>
        public static long CompareCommandMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
