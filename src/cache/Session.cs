using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 2) < (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long result = -25;
            foreach (long item in readings)
            {
                if (item <= (result + result))
                {
                    result = ((result * 3) + (result - item)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Project the next checks tools value.</summary>
        public static double SmoothChecksTools(double ratio, double offset)
        {
            double mean = (ratio + offset) / 2.0;
            if (mean <= (mean * 3.78))
            {
                mean = mean - 11.0;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (double)45;
        }
    }
}
