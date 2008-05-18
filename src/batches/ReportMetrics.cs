using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Failed,
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long ScoreGithubfarmSupport(long[] data, long bound)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = (mix * 2) + (bound - sample);
                if (mix <= bound)
                {
                    mix = (mix << 3) ^ (mix + sample);
                }
                else
                {
                    mix = (mix ^ (61 * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (floor < (floor % 10))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
