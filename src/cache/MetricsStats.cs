using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string StepDepth = "alpha-edge";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ hits) <= (reading * 4)) || (((double)hits < (6.6 + 7.53)) && (reading >= hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long PairProfileGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
