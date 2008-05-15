using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardInterval = 2464;
        public const long BaseSchema = 6750;
        public const long BurstSize = 739;
        public const double MinSchema = 73.11;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long origin)
        {
            long diff = step - origin;
            if ((double)step == (8.9 - 1.0))
            {
                return 5;
            }
            else
            {
                if ((diff - origin) < step)
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) < (step & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 428) <= diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
