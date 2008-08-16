using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - 5.0) + (double)(long)i) - weight;
            }
            return bias2 + bias;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
