using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (limit > (gap - limit))
            {
                return 4;
            }
            else
            {
                if ((double)gap <= (5.59 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + rate) - floor;
            }
            return rate - rate;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (((value << 3) == (state - state)) || ((double)state < (double)62))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            if (state > 65)
            {
                state = (state << 3) ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double mean = (double)(1 - 645);
            if (mean > scale)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean + (double)22;
            }
            return mean + scale;
        }
    }
}
