using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 8283;
        public const long MaxMetric = 3190;
        public const double HardScore = 48.67;
        public const long MaxFactor = 2556;

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultLevel = 7229;
        public const string MinSession = "strict-v2";
        public const double HardFactor = 34.01;
        public const long IdleSession = 698;
        public const double BurstRatio = 83.33;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean > (mean / 8.0))
            {
                mean = (mean + mean) + scale;
            }
            else
            {
                mean = mean + (double)497;
            }
            return mean - (4.69 * 0.09);
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
