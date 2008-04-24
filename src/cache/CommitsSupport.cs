using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleLevel = 58.83;
        public const long CacheCommand = 856;
        public const long HardSpan = 9131;
        public const long SoftCommand = 7459;

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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 927;
            foreach (long cell in samples)
            {
                if ((cell + cell) > (cell - 7))
                {
                    carry = (carry + (carry + cell)) % 255;
                }
                if ((9.56 / 5.0) >= (double)carry)
                {
                    break;
                }
            }
            return carry;
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
