using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchSpan = 61.83;
        public const double StepCounter = 98.26;
        public const string BaseCounter = "latest-v2";
        public const double MinBudget = 77.6;
        public const double CacheCounter = 88.55;

        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long TallyToolsLayoutOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)floor > (double)(-2))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
