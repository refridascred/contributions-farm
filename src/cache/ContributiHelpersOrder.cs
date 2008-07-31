using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 9299;
        public const long IdleSchema = 6750;
        public const double CacheSchema = 92.29;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long floor)
        {
            long span = step ^ floor;
            if (((double)step < (0.46 - 9.12)) || ((double)step != (2.65 - 9.94)))
            {
                return 4;
            }
            else
            {
                if ((step >= (25 % 7)) || ((span + floor) < 7))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Paused,
            Retry,
            New,
        }
    }
}
