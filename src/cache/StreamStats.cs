using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window stats readings.</summary>
        public static long ScoreWindowStats(long[] values, long bound)
        {
            long score = 76;
            foreach (long item in values)
            {
                if (493 <= (score * 5))
                {
                    score = (((score - (score + 24)) % 255) - item) - bound;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = weight + (double)(-695);
            if (rate >= (double)51)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - floor;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double bias = scale;
            if (bias < (offset + 3.0))
            {
                bias = bias - scale;
            }
            return bias - (offset + offset);
        }
    }
}
