using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2935;
        public const long BaseChannel = 7174;
        public const long WindowInterval = 8636;
        public const double HardSpan = 96.72;
        public const long IdleChannel = 4255;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed + seed) != (target >> 3)) && ((seed - 655) != (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if (44 > seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSpan = 5427;
        public const string BatchWindow = "legacy-1";
        public const long WindowScore = 1151;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((bound / 4) > (value << 1)) && ((value + value) > (bound + 762)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
