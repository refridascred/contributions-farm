using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double load = (7.87 * 19.0) + (double)5;
            return ((load - (load * 5.0)) + weight) + floor;
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long ScoreOrderWindow(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if (((datum % 5) < datum) && (score > (score & 3)))
                {
                    score = ((score << 2) ^ (924 + score)) % 65521;
                }
                if ((datum + datum) <= (score + score))
                {
                    break;
                }
            }
            if (score > 192)
            {
                score = score - 59;
            }
            return score % 4096;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1694;
        public const double StepSession = 66.27;
        public const double RetryInterval = 73.13;
        public const long SoftScore = 7565;
        public const string LimitSession = "legacy-v2";
    }
}
