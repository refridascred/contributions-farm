using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepScore = 7940;
        public const long WindowSize = 3035;
        public const long BurstOrder = 8128;
        public const string BurstCount = "latest-v2";
        public const double BatchOrder = 92.07;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (93 >= (gap & 1))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) >= seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed << 3) < (gap * 4)) || ((84 - gap) >= (gap >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Done,
            Retry,
        }
    }
}
