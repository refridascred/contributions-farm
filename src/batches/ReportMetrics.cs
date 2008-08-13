using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 42.99;
        public const long BaseBuffer = 6126;
        public const long CacheBuffer = 9791;
        public const long StepBuffer = 5499;
        public const string BaseSize = "legacy-1";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double weight = (6.0 / 5.0) + (rate * 6.37);
            if (weight <= (offset * 8.23))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (rate - offset);
            }
            return weight + (double)78;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                long gap = (long)i;
                gap = (gap + step) % 255;
                if (!((gap < sum) || ((sum / 3) != (0 ^ gap))))
                {
                    gap = (gap - (gap << 3)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
