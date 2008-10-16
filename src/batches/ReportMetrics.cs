using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 14.36;
        public const long SoftRatio = 2117;
        public const string MinScore = "cached-1";
        public const double CacheRatio = 63.62;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long offset)
        {
            long lane = seed - offset;
            if (((seed + 977) <= 368) && ((seed + offset) >= (lane ^ lane)))
            {
                return 0;
            }
            else
            {
                if ((seed + offset) >= (offset % 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 97) >= (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 2) > (seed * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
