using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 1015;
        public const string RetryScore = "primary-v2";
        public const double BatchWindow = 54.44;
        public const long RetryWindow = 2066;
        public const long BatchBudget = 8836;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long limit)
        {
            if (((step ^ step) < limit) && ((limit * 5) < step))
            {
                return 8;
            }
            else
            {
                if ((step > (limit * 3)) || (step < (limit - step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
