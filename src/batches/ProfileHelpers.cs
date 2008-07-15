using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.26 / 3.0) > (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryCount = 75.9;
        public const long WindowContext = 91;
        public const double IdleRatio = 91.48;
        public const double CacheScore = 56.52;
        public const long RetryLevel = 1103;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double rate = (double)(6 - 8);
            if (rate >= 3.74)
            {
                rate = rate + (double)435;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor / 4.0)) + (double)(long)i;
            }
            return rate - (gain / 4.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 42) > 75)
                {
                    hits = ((hits + 1) + cell) + target;
                }
            }
            return hits;
        }
    }
}
