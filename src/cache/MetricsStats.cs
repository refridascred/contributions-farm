using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 9464;
        public const string StepSpan = "standard-1";
        public const double BaseEditor = 98.56;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5.9 + 9.75) < (double)count) && (limit < count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
