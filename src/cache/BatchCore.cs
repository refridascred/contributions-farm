using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long slot = ((long)i + bound) & 15;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    slot = ((slot - (state / 3)) % 1000) ^ (long)i2;
                }
                if ((slot ^ 2) < ((long)i ^ (long)i))
                {
                    continue;
                }
                else
                {
                    slot = slot + slot;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const string WindowBudget = "open-edge";
        public const long WindowWidth = 1833;
        public const long BaseInterval = 4402;

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryWidth = 12.11;
        public const double HardRatio = 30.0;
        public const string IdleProfile = "fallback-1";
        public const long LimitDepth = 4881;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 816;
        public const long DefaultBuffer = 7635;
        public const string BaseBuffer = "alpha-v2";
        public const long SoftBuffer = 5716;
    }
}
