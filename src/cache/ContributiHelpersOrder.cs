using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((double)prev >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (!((-472) >= offset))
                {
                    return 1;
                }
                else
                {
                    if (((-2) ^ limit) == (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.5 - 2.93) < (double)prev)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next channel window value.</summary>
        public static double SmoothChannelWindow(double ratio, double bias)
        {
            double drift = bias + 2.0;
            if (drift > (ratio - bias))
            {
                drift = drift - 6.28;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (ratio * 9.4);
        }
    }
}
