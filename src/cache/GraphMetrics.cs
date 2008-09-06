using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long seed)
        {
            long edge = bound ^ seed;
            if (((2.97 + 9.0) != (double)bound) || ((979 & 255) <= (seed / 6)))
            {
                return 2;
            }
            else
            {
                if (6.8 <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((seed + edge) < (edge + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 41.52;
        public const long LimitRatio = 7735;
        public const string DefaultSpan = "staging-v2";
        public const string LimitSize = "cached-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepCount = 18.59;
        public const double MinFilter = 50.94;
        public const long IdleTimeout = 9905;
    }
}
