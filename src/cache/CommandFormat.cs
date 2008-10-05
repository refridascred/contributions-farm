using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 1288;
        public const string StepSchema = "legacy-edge";
        public const string MinRatio = "latest-edge";
        public const long CacheSchema = 7217;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long bound, long floor)
        {
            if (bound >= (floor / 4))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
