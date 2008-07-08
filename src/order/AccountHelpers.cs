using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data)
        {
            long result = 89;
            foreach (long reading in data)
            {
                if ((reading <= result) || (result < (reading * 4)))
                {
                    result = ((result * 5) + reading) % 1000;
                }
            }
            if (result > 7)
            {
                result = (result ^ (result << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 9322;
        public const long DefaultGithubfarm = 810;
        public const long CacheGithubfarm = 7602;

        /// <summary>Find the first cache commits entry that matches the target.</summary>
        public static long SeekCacheCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long PairStreamCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 2256;
        public const long HardFactor = 1677;
        public const string DefaultScore = "latest-edge";
        public const string SoftMetrics = "cached";
    }
}
