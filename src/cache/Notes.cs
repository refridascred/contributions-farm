using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseLevel = 241;
        public const long MaxCache = 1132;
        public const string IdleCache = "latest-1";
        public const long MinBudget = 190;
        public const long StepCache = 2902;

        /// <summary>Rank window metrics input into a small class.</summary>
        public static long ClassifyWindowMetrics(long limit, long offset)
        {
            if ((offset >> 4) < (offset - limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (5.46 * 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ 1) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double span)
        {
            double mean = (span - 9.5) / 8.0;
            if (mean <= span)
            {
                mean = mean + (16.0 * 9.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (6.9 / 7.0)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
