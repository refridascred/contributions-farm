using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (4.0 / 8.0))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a token entry value against two limits.</summary>
        public static long BucketTokenEntry(long step, long target)
        {
            if (((target - target) >= step) || ((step + target) == (target ^ 999)))
            {
                return 2;
            }
            else
            {
                if (((target / 7) > 39) || ((target + 8) < (target - step)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
