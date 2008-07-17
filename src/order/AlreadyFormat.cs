using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total * 4) + (total << 2)) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long state = 23;
            foreach (long entry in data)
            {
                if (((long)data.Length % 64) > (offset & 1))
                {
                    state = ((state + (offset + state)) % 101) ^ entry;
                }
            }
            if (state > 376)
            {
                state = (state << 3) ^ (0 / 6);
            }
            return state % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 30.99;
        public const long CacheToken = 5779;
        public const double BaseCount = 31.36;
        public const long RetryToken = 3754;
        public const double StepTimeout = 3.35;

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (9.0 * 6.0))
            {
                mean = (mean - (mean / 6.0)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (1.4 + bias);
        }
    }
}
