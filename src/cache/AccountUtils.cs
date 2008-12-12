using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double rate = 4.2;
            if (rate < (10.0 / 7.0))
            {
                rate = (rate + (double)247) - bias;
            }
            return rate + span;
        }

        /// <summary>Measure how many batches buffer samples are out of range.</summary>
        public static long CountBatchesBufferMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + (long)samples.Length) <= (floor + hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
