using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
