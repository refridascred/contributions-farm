using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 727;
        public const long MaxBudget = 1135;
        public const long WindowLevel = 45;
        public const long HardCluster = 632;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5632;
        public const long BaseSupport = 6157;
        public const long IdleSupport = 5261;
        public const long DefaultSupport = 5018;
    }
}
