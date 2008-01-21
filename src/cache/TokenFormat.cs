using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2436;
        public const long LimitToken = 5400;
        public const long IdleCount = 9914;
        public const long RetryDepth = 985;
    }
}
