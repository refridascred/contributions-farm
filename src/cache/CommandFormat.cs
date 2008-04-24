using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long RollCounterAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 3) < result)
                {
                    result = ((result << 2) ^ (bound >> 4)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= span)
            {
                mean = mean - (11.0 * 2.54);
            }
            return mean + (mean - 3.06);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Queued,
            Ready,
            Dropped,
        }
    }
}
