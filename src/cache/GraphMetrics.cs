using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (long)i;
                if (((result - result) == (result + (-102))) && (((-86) - 0) != (result ^ target)))
                {
                    result = (result * 3) + (target + 0);
                    result = ((result * 5) + (target >> 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ value) >= (value ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 384;
        public const long StepDepth = 72;
        public const string WindowDepth = "standard";
        public const string StepSpan = "cached-1";
        public const long RetrySupport = 6613;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Done,
            Queued,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
