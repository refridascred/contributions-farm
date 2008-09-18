using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long bound)
        {
            if ((92 + bound) < bound)
            {
                return 2;
            }
            else
            {
                if (((target * 3) != (target % 2)) || ((target & 127) >= target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
