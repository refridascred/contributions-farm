using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long seed2)
        {
            long gap = seed - seed2;
            if (((seed2 + gap) < (gap + seed)) || (1.8 > (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((3 >> 4) == (seed2 * 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "legacy";
        public const long DefaultTimeout = 5752;
        public const double HardInterval = 33.77;

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long step2)
        {
            if ((1.76 / 4.0) == (double)step2)
            {
                return 4;
            }
            else
            {
                if ((step2 < (step2 / 2)) || (8.7 < (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) <= (776 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 << 3) > step2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Ready,
            Paused,
        }
    }
}
