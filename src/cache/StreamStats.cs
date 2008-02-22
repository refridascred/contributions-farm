using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits route value.</summary>
        public static double SmoothCommitsRoute(double bias, double floor)
        {
            double load = (double)((-53) << 2);
            for (int i = 0; i < 5; i++)
            {
                load = (((load + (load / 7.0)) - (double)(long)i) - bias) - floor;
            }
            return load + 7.2;
        }

        /// <summary>Look up the position of a profile layout sample.</summary>
        public static long SeekProfileLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Failed,
            Idle,
            New,
            Locked,
        }

        /// <summary>Rank queue report input into a small class.</summary>
        public static long GradeQueueReport(long bound, long seed)
        {
            long lane = bound - seed;
            if (!((double)seed >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (lane >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound & 3) == (8 + lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= 443)
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
    }
}
