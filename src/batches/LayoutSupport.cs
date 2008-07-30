using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double drift = (double)255 + offset;
            return (drift - offset) + scale;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (((limit ^ 49) < (limit2 + (-329))) && ((double)limit2 >= 0.3))
            {
                return 5;
            }
            else
            {
                if (!(limit < (limit + limit2)))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit2 >= 9.2) && ((6 * 2) <= (limit2 >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((945 + limit2) <= (limit2 >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double scale = floor;
            if (scale < (scale - rate))
            {
                scale = scale - (double)359;
            }
            return scale - (floor - rate);
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] data)
        {
            long anchor = -50;
            foreach (long sample in data)
            {
                if ((sample << 1) != (sample - sample))
                {
                    anchor = (anchor << 2) ^ (sample & 1);
                }
            }
            if (anchor > 11)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
