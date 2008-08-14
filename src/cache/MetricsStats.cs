using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3654;
        public const long LimitCount = 9247;
        public const string BurstBudget = "alpha";
        public const long SoftAlready = 7286;
        public const long BatchFactor = 4524;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 7476;
        public const string IdleCache = "legacy-edge";
        public const long HardTimeout = 9398;

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long DigestStatsGithubfarm(long[] samples, long floor)
        {
            long state = 37;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ state;
                if ((double)floor > (double)790)
                {
                    state = state - entry;
                }
            }
            return state;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
