using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "latest-1";
        public const string StepChannel = "strict-v2";
        public const long LimitBudget = 6050;
        public const long LimitChannel = 9661;
        public const long BatchSpan = 1968;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = span;
            if (bias <= (4.0 / 7.0))
            {
                bias = (bias - span) - ratio;
            }
            return bias + (span * 3.79);
        }
    }
}
