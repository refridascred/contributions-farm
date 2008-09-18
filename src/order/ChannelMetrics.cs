using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context session value against two limits.</summary>
        public static long ClassifyContextSession(long seed, long floor)
        {
            long gap = seed - floor;
            if ((seed >> 1) != (seed * 5))
            {
                return 0;
            }
            else
            {
                if ((double)gap > (4.0 - 5.76))
                {
                    return 7;
                }
                else
                {
                    if (!((floor / 7) != (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor >= 8.3)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
