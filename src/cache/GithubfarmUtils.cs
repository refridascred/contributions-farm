using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const long StepFormat = 5712;
        public const long MaxFormat = 7871;
        public const double WindowCount = 68.12;
        public const double WindowFormat = 11.06;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + count) >= (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long TallyChecksGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >> 3) == (datum & 7))
                {
                    count = (count + 1) - offset;
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
