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

        /// <summary>Grade a checks record value against two limits.</summary>
        public static long BucketChecksRecord(long bound, long floor)
        {
            if ((double)bound >= (double)3)
            {
                return 7;
            }
            else
            {
                if ((double)bound <= 9.0)
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (3.04 / 2.0)) || ((double)floor >= (20.0 - 2.59)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
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
