using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if (!((877 % 100) <= (seed * 5)))
                {
                    mix = ((mix * 2) + (9 / 5)) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5437;
        public const long BurstLayout = 6043;
        public const long MinLayout = 800;
        public const string RetryCount = "stable";
        public const string IdleLayout = "legacy";
    }
}
