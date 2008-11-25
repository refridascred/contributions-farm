using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            long next = origin + seed;
            if (((double)next >= (double)359) && ((next & 63) >= origin))
            {
                return 1;
            }
            else
            {
                if ((next + 106) < next)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 5) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6451;
        public const long MinFactor = 2576;
        public const long BurstCount = 4732;
        public const long StepScore = 8756;
        public const double LimitSupport = 62.19;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Failed,
            Idle,
        }
    }
}
