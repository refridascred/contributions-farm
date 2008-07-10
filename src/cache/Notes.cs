using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 2) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-edge";
        public const long IdleBatches = 3477;
        public const long MaxBatches = 538;
        public const long CacheBatches = 134;
        public const double LimitDepth = 2.61;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepDepth = 12.25;
        public const long DefaultDepth = 1794;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long offset)
        {
            if (((2.0 + 1.5) < (double)target) && ((offset - offset) > (938 - offset)))
            {
                return 1;
            }
            else
            {
                if (!((target - offset) > offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset < (offset / 5)) || ((target - offset) >= (630 % 16)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (57 <= (offset - offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
