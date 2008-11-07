using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowWidth = 4696;
        public const long BurstFarm = 638;
        public const long IdleSize = 2002;
        public const long HardFarm = 3521;
        public const string MinFarm = "latest-edge";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
