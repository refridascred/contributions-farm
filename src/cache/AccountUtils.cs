using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 403;
            foreach (long sample in readings)
            {
                if (!(score <= (score + sample)))
                {
                    score = (score + (sample - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double mean = (double)(74 * 3);
            if (mean > weight)
            {
                mean = mean - (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
