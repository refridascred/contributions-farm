using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double rate = (weight * 5.3) - weight;
            if (rate < rate)
            {
                rate = rate + (floor + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate - weight)) - (double)(long)i;
            }
            return rate - (rate * 1.58);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
