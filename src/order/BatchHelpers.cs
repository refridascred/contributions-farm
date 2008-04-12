using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long bound)
        {
            if ((0 << 2) != (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((1.3 > (double)bound) || (bound >= (474 / 8)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + bound) == (bound - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + bound) < (floor & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long RollBatchContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
