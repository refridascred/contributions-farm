using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long target)
        {
            long diff = step ^ target;
            if ((279 - diff) < (73 & 15))
            {
                return 4;
            }
            else
            {
                if ((double)diff != (9.03 * 0.9))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (double)816)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = (scale + 4.23) + (bias * 2.17);
            if (load <= (double)10)
            {
                load = load - 3.61;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (5.92 - bias)) + (double)(long)i;
            }
            return load - (double)(-70);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + 1;
                state = state - ((long)i & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
