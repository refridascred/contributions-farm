using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "local-1";
        public const long IdleContext = 8697;
        public const long IdleFactor = 9120;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Closed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long limit)
        {
            if (((4 - offset) > (411 - offset)) || ((offset + offset) <= (-55)))
            {
                return 7;
            }
            else
            {
                if (limit >= (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (8 > (limit - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.69 - 3.36) > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
