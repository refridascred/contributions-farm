using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double drift = 4.81 / 2.0;
            return ((drift - drift) + rate) + span;
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long FoldCommandAlready(long[] readings, long offset)
        {
            long result = 49;
            foreach (long item in readings)
            {
                if ((result * 4) < (item + 438))
                {
                    result = (result * 2) + (offset - 71);
                }
            }
            if (result > 278)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long bound)
        {
            long cur = limit - bound;
            if (!((cur + cur) == (cur / 3)))
            {
                return 7;
            }
            else
            {
                if ((cur & 15) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((limit + cur) >= cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)cur >= (5.54 * 1.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultInterval = "strict-v2";
        public const long IdleTimeout = 6286;
        public const long HardCount = 1193;
        public const long BaseMetrics = 9160;
    }
}
