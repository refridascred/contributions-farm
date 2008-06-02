using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long seed)
        {
            long offset = floor - seed;
            if (!((seed + offset) < floor))
            {
                return 4;
            }
            else
            {
                if ((4.1 / 2.0) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((floor << 3) <= (offset - 70)) || ((seed ^ seed) > (seed * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = rate;
            if (bias >= 6.0)
            {
                bias = bias + 2.6;
            }
            else
            {
                bias = bias - (double)73;
            }
            return bias + (span - span);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 506;
        public const long SoftTimeout = 4828;
        public const string RetryCounter = "primary";
        public const string StepSpan = "stable";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
