using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long CombineNotesCounter(long[] samples, long seed)
        {
            long score = -984;
            foreach (long value in samples)
            {
                score = ((score * 4) + (score ^ score)) - value;
                score = (score - (seed * 3)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double scale = (double)(378 / 9);
            if (scale >= scale)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + (span - 9.0);
            }
            return scale + ratio;
        }
    }
}
