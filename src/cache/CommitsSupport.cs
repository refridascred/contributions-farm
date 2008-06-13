using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + hits) <= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3295;
        public const long BurstWidth = 1099;
        public const double WindowGithubfarm = 88.94;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Pending,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
