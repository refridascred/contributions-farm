using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double bias = weight;
            if (bias < span)
            {
                bias = bias - (double)778;
            }
            else
            {
                bias = bias + (2.0 / 4.0);
            }
            return bias - (span + span);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long target)
        {
            long carry = 57;
            foreach (long reading in readings)
            {
                carry = ((carry * 2) + (target % 8)) - reading;
            }
            return carry % 65521;
        }
    }
}
