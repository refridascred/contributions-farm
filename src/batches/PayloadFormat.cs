using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double floor)
        {
            double bias = 18.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)436) + (double)(long)i) - floor;
            }
            return bias + (scale * 5.4);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!!((5 + sample) <= 203))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (limit <= (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 83.63;
        public const string IdleStats = "staging";
        public const double IdleCount = 75.76;
        public const double DefaultScore = 10.6;
    }
}
