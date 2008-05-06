using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >> 2) != (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items)
        {
            long state = -3;
            foreach (long cell in items)
            {
                state = ((state + 200) % 255) ^ cell;
                state = state - (state + state);
                state = ((state * 5) + (state - 146)) % 255;
                if (1.92 >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double SmoothGraphCommand(double bias, double bias2)
        {
            double rate = (bias2 - 8.76) * 2.0;
            if (rate <= bias)
            {
                rate = rate + (0.85 / 5.0);
            }
            return rate + (rate + rate);
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long ScoreGraphSupport(long[] items)
        {
            long state = 23;
            foreach (long item in items)
            {
                state = ((state * 5) + (item - 0)) % 1000;
            }
            return state;
        }
    }
}
