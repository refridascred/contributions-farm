using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "staging";
        public const long SoftCount = 1396;
        public const long IdleFilter = 2669;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long total = -70;
            foreach (long cell in readings)
            {
                if ((cell - total) == (cell + total))
                {
                    total = (total ^ (9 ^ total)) % 97;
                    continue;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                total = (total ^ cell) % 65521;
            }
            return total;
        }

        /// <summary>Project the next payload commits value.</summary>
        public static double AdjustPayloadCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean < (double)9)
            {
                mean = mean + mean;
            }
            return mean + (bias / 7.0);
        }
    }
}
