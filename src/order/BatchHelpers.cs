using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryLevel = 70.77;
        public const long StepRecord = 9158;
        public const long WindowLevel = 1100;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ (total / 4)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
