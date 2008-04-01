using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((bound << 3) < (369 - count)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of already githubfarm readings.</summary>
        public static long PairAlreadyGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 1266;
        public const long BurstFilter = 9334;
        public const long DefaultCount = 6376;
        public const long StepFilter = 8988;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            Paused,
            Queued,
            Draft,
        }
    }
}
