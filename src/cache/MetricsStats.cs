using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long TallyContextProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (matches / 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches layout entry stays within the limit.</summary>
        public static bool CheckBatchesLayoutBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long bound)
        {
            if (((step - step) <= 432) && ((double)bound >= (double)70))
            {
                return 5;
            }
            else
            {
                if (bound > step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.36 * 6.3) < (double)reading)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
