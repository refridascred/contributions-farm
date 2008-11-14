using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload tools readings.</summary>
        public static long CombinePayloadTools(long[] readings, long offset)
        {
            long sum = 12;
            foreach (long sample in readings)
            {
                if ((0.6 - 8.4) >= (double)sample)
                {
                    sum = ((sum + sum) % 1000) + offset;
                }
                if ((sum % 24) != (3 / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxBudget = 37.58;
        public const long HardDepth = 5623;
        public const long BurstBudget = 8046;
        public const long WindowFilter = 3292;

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
