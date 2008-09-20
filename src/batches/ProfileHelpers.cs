using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a tools session counter forward.</summary>
        public static long SeriesToolsSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double gain = rate;
            return (gain - (0.12 * 1.9)) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 94.77;
        public const double BurstScore = 68.23;
        public const long StepInterval = 1212;
        public const long RetryCount = 947;
        public const long WindowGithubfarm = 2537;

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (1.0 * 9.7))
            {
                bias2 = (bias2 - (floor + floor)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (3.0 / 7.0)) + (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
