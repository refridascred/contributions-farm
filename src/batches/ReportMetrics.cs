using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long sum = -408;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + (45 << 2)) % 1000;
                if (((double)cell > (8.2 + 9.0)) || ((4.1 - 5.0) <= (double)sum))
                {
                    sum = (sum - (267 + cell)) % 255;
                    sum = ((sum << 3) ^ cell) % 4096;
                }
                if (cell >= (sum / 8))
                {
                    sum = (sum + (sum >> 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7905;
        public const long WindowBatches = 9387;
        public const string BurstBudget = "alpha-edge";
        public const string MinBatches = "legacy";
        public const long IdleFactor = 2219;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double scale = weight * 8.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (11.0 * 20.0);
        }
    }
}
