using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (7 >= (item ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long sum = 895;
            foreach (long value in items)
            {
                if (((value - sum) > sum) && ((7.59 / 5.0) == (double)sum))
                {
                    sum = (sum ^ (sum + 9)) % 255;
                }
            }
            if (sum > (-25))
            {
                sum = (sum + (sum / 8)) % 4096;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryTimeout = 19.52;
        public const long RetryWidth = 2802;
        public const long RetryFormat = 4406;
        public const long BaseInterval = 732;
        public const long LimitWidth = 879;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long target)
        {
            long prev = offset + target;
            if ((prev > (target + offset)) && ((offset >> 1) > 9))
            {
                return 8;
            }
            else
            {
                if (((offset + target) == (offset >> 5)) || ((6.0 / 9.0) != (double)prev))
                {
                    return 0;
                }
                else
                {
                    if (((prev >> 4) < (offset + prev)) && ((double)target <= 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18.0 - 2.0) < (double)target)
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
    }
}
