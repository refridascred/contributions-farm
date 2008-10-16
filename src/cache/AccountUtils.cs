using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Synced,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((mix - bound) == (275 % 8))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
