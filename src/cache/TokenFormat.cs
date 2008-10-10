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

        /// <summary>Roll a stream support counter forward.</summary>
        public static long RollStreamSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - mark) % 65521;
                if ((long)i > mark)
                {
                    mark = (mark << 2) ^ (0 & 7);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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
