using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a cache order pair into a bucket.</summary>
        public static long GradeCacheOrder(long target, long target2)
        {
            long offset = target + target2;
            if (((target2 % 2) != (target * 2)) && ((double)offset == (4.9 * 1.0)))
            {
                return 1;
            }
            else
            {
                if (((4.38 / 9.0) < (double)offset) && ((offset + target) >= (offset - (-66))))
                {
                    return 3;
                }
                else
                {
                    if ((target & 255) > (target2 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ (item % 5)) % 255;
            }
            if (carry < 5)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 24.26;
        public const double IdleLevel = 5.6;
        public const long MinStats = 8536;
    }
}
