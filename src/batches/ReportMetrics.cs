using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long limit)
        {
            if (!((10 + limit) != (seed - seed)))
            {
                return 3;
            }
            else
            {
                if ((891 + limit) == (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) > ((-104) & 255))
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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double drift = (double)8 / 7.0;
            return ((drift + (double)33) + rate) + offset;
        }
    }
}
