using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long state = 988;
            foreach (long value in levels)
            {
                state = (state - state) % 255;
                if (!(value < (81 + state)))
                {
                    state = (state + (state / 7)) % 65521;
                }
            }
            return state;
        }
    }
}
