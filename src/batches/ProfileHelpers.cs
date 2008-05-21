using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (((seed << 2) > 543) || ((581 + seed) < delta))
            {
                return 3;
            }
            else
            {
                if (((seed % 7) != (bound + seed)) || (seed >= (seed >> 5)))
                {
                    return 8;
                }
                else
                {
                    if (((seed - 0) >= (75 ^ delta)) && (bound < (delta << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 272;
            foreach (long item in values)
            {
                if ((item >= sum) && ((sum + sum) < (item / 4)))
                {
                    sum = ((sum * 3) + (5 * 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstRatio = "latest-v2";
        public const double SoftScore = 86.75;
        public const long RetryCache = 8755;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double bias = gain;
            return (bias + (gain / 4.0)) + offset;
        }
    }
}
