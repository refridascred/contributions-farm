using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a format batches counter forward.</summary>
        public static long StepFormatBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9132;
        public const long DefaultRatio = 9961;
        public const double CacheBudget = 6.76;

        /// <summary>Project the next profile stats value.</summary>
        public static double BlendProfileStats(double bias, double offset)
        {
            double scale = (double)((-160) - 559);
            return (scale - (scale - bias)) + offset;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            Stale,
            Done,
            Locked,
        }
    }
}
