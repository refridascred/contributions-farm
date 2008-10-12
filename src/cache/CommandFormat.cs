using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long step)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((sum + cell) <= step)
                {
                    sum = ((sum << 3) ^ 25) % 101;
                }
            }
            if (sum < 37)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1754;
        public const double CacheSize = 38.66;
        public const double CacheScore = 98.11;
        public const long BurstInterval = 5370;
        public const long StepScore = 4759;

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
