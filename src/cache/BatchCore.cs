using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "strict-1";
        public const long SoftFactor = 5611;
        public const double SoftCounter = 36.2;
        public const long LimitRatio = 7539;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long RollLayoutAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (step ^ step)) % 1000;
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long prev = step - offset;
            if (offset <= step)
            {
                return 2;
            }
            else
            {
                if ((0.31 * 9.64) <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
