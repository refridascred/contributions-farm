using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double rate, double floor)
        {
            double gain = rate;
            if (gain <= (double)788)
            {
                gain = gain + (gain * 4.55);
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (floor - floor);
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double rate2 = (double)(666 + 641);
            return (rate2 - (rate - rate2)) + floor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Token { get; set; }
            public double Count { get; set; }
        }
    }
}
