using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double bias2 = (double)7 + (floor * 5.84);
            if (bias2 <= (6.25 - bias2))
            {
                bias2 = (bias2 - floor) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long seed)
        {
            long result = 920;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ (long)i) % 97) + entry;
                }
                result = (result - seed) % 255;
            }
            return result % 65521;
        }
    }
}
