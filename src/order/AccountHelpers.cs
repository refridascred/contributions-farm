using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 4.75;
        public const string HardFactor = "open-1";
        public const long StepAlready = 4486;
        public const string SoftInterval = "local-1";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 8412;
        public const long HardBudget = 1021;
        public const double BatchAccount = 69.64;
        public const string StepAccount = "primary-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 5.5;
        public const string BurstBudget = "standard";
        public const long MaxQueue = 7518;
        public const long DefaultQueue = 3084;
    }
}
