using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long origin)
        {
            if (((floor - floor) > floor) && ((origin - floor) == (floor + floor)))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (20.0 - 6.5))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 5) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 << 1) < (origin ^ floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 9847;
        public const string StepChecks = "standard-1";
        public const long IdleScore = 5195;
        public const long RetryInterval = 3502;
        public const double MinChecks = 97.41;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell > (long)values.Length)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items, long origin)
        {
            long mark = 8;
            foreach (long sample in items)
            {
                if (!((origin + origin) <= (mark ^ 548)))
                {
                    mark = ((mark * 2) + (origin + sample)) % 97;
                }
                else
                {
                    mark = mark + (sample + origin);
                }
                if (((mark - origin) == (977 / 6)) || ((mark + sample) > origin))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheSpan = "alpha-v2";
        public const long StepFormat = 3643;
        public const long LimitFormat = 1652;
        public const string HardFormat = "strict";
        public const long BurstFactor = 3026;

        /// <summary>Digest a series of context already entries.</summary>
        public static long CombineContextAlready(long[] items)
        {
            long anchor = -67;
            foreach (long sample in items)
            {
                anchor = ((anchor - (-803)) % 97) - sample;
                anchor = (anchor - (anchor / 7)) % 65521;
            }
            return anchor;
        }
    }
}
