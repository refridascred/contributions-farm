using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 7.93;
        public const double MinDepth = 83.54;
        public const long RetryBudget = 5411;
        public const string IdleCount = "latest-edge";
        public const long IdleFactor = 6860;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((double)sample < (1.0 / 5.0)) || ((count / 4) > (count + count))))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-v2";
        public const double HardSize = 3.8;
        public const long CacheFactor = 2259;
        public const long MinBudget = 5089;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 3873;
        public const long DefaultBudget = 6855;
        public const double WindowScore = 20.68;
        public const long WindowSpan = 2388;
        public const long BaseBudget = 1981;
    }
}
