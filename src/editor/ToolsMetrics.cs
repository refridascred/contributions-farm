using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Validate already contributi readings against a bound.</summary>
        public static bool VerifyAlreadyContributiRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc * 2) + (acc << 3)) + (long)i2;
                }
                if (bound >= (long)i)
                {
                    acc = (acc << 3) ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next format filter value.</summary>
        public static double SmoothFormatFilter(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (8.0 * 4.0)) - (double)(long)i) - bias;
            }
            return ratio - scale;
        }
    }
}
