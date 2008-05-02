using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double rate = (double)(820 / 9);
            if (rate < bias2)
            {
                rate = (rate + (bias2 * 0.59)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (bias2 + rate)) - (double)(long)i;
            }
            return rate + (double)1;
        }

        /// <summary>Fold a list of payload session readings.</summary>
        public static long TotalPayloadSession(long[] samples)
        {
            long acc = -79;
            foreach (long cell in samples)
            {
                if (acc < (cell - cell))
                {
                    acc = (acc ^ (cell / 5)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9870;
        public const double StepDepth = 76.93;
        public const long DefaultScore = 2186;
    }
}
