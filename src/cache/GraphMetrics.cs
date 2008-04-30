using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((limit - 66) > (limit + limit))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 55.16;
        public const long StepDepth = 6712;
        public const string BatchDepth = "local-edge";
        public const double LimitSpan = 20.59;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long step2)
        {
            long cur = step + step2;
            if (((step >> 5) == (cur ^ cur)) || (step2 < (1 % 5)))
            {
                return 4;
            }
            else
            {
                if ((step2 ^ step) != (step2 + cur))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 >= 6.8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 / 4.0) < (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm account samples.</summary>
        public static long TotalFarmAccount(long[] levels)
        {
            long state = 90;
            foreach (long reading in levels)
            {
                if (((7.69 + 7.4) > (double)reading) && ((double)state < 3.9))
                {
                    state = (state * 4) + reading;
                }
            }
            return state % 97;
        }
    }
}
