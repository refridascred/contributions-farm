using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (seen ^ reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mark = 4;
            foreach (long value in series)
            {
                if (!((mark & 63) > (mark % 24)))
                {
                    mark = ((mark << 2) ^ (value / 5)) % 4096;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
