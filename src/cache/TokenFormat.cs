using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every context layout entry stays within the limit.</summary>
        public static bool CheckContextLayoutRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double bias2 = ratio / 6.0;
            if (bias2 < ratio)
            {
                bias2 = bias2 - (bias2 / 4.0);
            }
            else
            {
                bias2 = bias2 + (double)7;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias2 / 9.0)) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Ready,
            Pending,
            Done,
        }
    }
}
