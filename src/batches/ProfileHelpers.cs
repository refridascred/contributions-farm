using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double bias2 = (span / 2.0) + span;
            if (bias2 > (span / 7.0))
            {
                bias2 = (bias2 + 0.7) - bias;
            }
            return bias2 - (span / 7.0);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long limit)
        {
            if ((floor >> 3) == (floor - limit))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (1.57 - 3.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
