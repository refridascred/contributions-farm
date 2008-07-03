using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (5.32 + 3.0))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
