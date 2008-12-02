using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxTimeout = 49.21;
        public const long RetryInterval = 5331;
        public const long StepFactor = 911;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long seed)
        {
            if (((seed - step) <= (seed & 3)) && ((step % 8) >= 8))
            {
                return 1;
            }
            else
            {
                if ((7.7 / 5.0) != (double)seed)
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
