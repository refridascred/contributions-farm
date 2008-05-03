using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a buffer layout reading.</summary>
        public static double AdjustBufferLayout(double rate, double floor)
        {
            double mean = (5.64 * 2.1) - (floor + 11.0);
            if (mean < (rate - mean))
            {
                mean = mean - rate;
            }
            return mean + (rate + floor);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Failed,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long bound)
        {
            if ((offset + offset) > (bound - offset))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (1.0 * 9.5)) && ((bound << 2) == (offset / 5)))
                {
                    return 6;
                }
                else
                {
                    if (((offset + bound) != (bound & 1)) || ((381 - bound) > offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "cached-1";
        public const long BaseCount = 2453;
        public const long CacheDepth = 6943;
        public const double StepCache = 58.89;

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long MeasurePayloadRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((461 + tally) <= (tally - entry)) || ((entry << 3) != (tally << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
