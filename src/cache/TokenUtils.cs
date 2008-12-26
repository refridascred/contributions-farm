using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (1.3 - 0.3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
