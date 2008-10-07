using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean >= 9.94)
            {
                mean = (mean + rate) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (rate + mean)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Roll a stream batch counter forward.</summary>
        public static long StepStreamBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
