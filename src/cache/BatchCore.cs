using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
