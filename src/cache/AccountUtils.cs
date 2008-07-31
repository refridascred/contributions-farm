using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double gain = (4.3 * 5.7) * 2.16;
            return ((gain + (double)82) + rate) + bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long bound)
        {
            long score = 13;
            foreach (long entry in samples)
            {
                score = (((score + score) % 101) ^ entry) - bound;
            }
            return score % 65521;
        }
    }
}
