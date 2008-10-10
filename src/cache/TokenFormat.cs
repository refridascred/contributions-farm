using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double drift = (double)(9 & 15);
            if (drift < (double)205)
            {
                drift = (drift - (bias + drift)) + scale;
            }
            return drift - (double)7;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long target)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if (((double)target == (1.61 * 1.3)) && ((datum - datum) > target))
                {
                    score = score - (target ^ target);
                    break;
                }
                if ((datum + (long)samples.Length) <= 245)
                {
                    score = (score * 2) + (target - target);
                }
                else
                {
                    score = (score + (score / 9)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
