using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Audit editor githubfarm readings against a rule.</summary>
        public static long CountEditorGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) > (value & 127))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (4 * 3)) % 101) + cell;
            }
            return anchor % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count * 4) == (count - count))
                {
                    count = ((count + 1) ^ sample) - limit;
                }
            }
            return count;
        }
    }
}
