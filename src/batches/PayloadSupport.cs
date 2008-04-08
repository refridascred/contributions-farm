using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (9 > (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double mean = (double)(78 + 93);
            if (mean >= (bias + mean))
            {
                mean = (mean + bias) - rate;
            }
            else
            {
                mean = mean - (bias * 16.0);
            }
            return mean - mean;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSpan = 1755;
        public const long WindowSpan = 419;
        public const long HardGraph = 8532;
        public const double BurstSize = 98.55;
    }
}
