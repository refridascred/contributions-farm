using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result + cell) + offset;
            }
            if (result < 221)
            {
                result = result ^ 411;
            }
            return result;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (offset * 15.0)) - (double)(long)i) - ratio;
            }
            return gain + (offset * 8.0);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long state = 1;
            foreach (long datum in readings)
            {
                state = ((state ^ (step % 7)) % 65521) + datum;
            }
            return state % 65521;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Iterate the stats metrics series from a seed.</summary>
        public static long StepStatsMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score + (score ^ offset)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
