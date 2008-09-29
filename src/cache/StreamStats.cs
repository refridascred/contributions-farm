using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            long gap = bound + floor;
            if (!((double)bound > (double)floor))
            {
                return 8;
            }
            else
            {
                if ((gap - floor) == (floor - bound))
                {
                    return 7;
                }
                else
                {
                    if ((7 / 3) < (bound << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 25.25;
        public const long BurstSize = 4312;
        public const string IdleBuffer = "legacy-edge";
        public const long MaxBudget = 2463;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Synced,
            Locked,
            Dropped,
            Failed,
        }
    }
}
