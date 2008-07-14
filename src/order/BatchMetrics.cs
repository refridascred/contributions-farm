using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Grade a context commits value against two limits.</summary>
        public static long ClassifyContextCommits(long limit, long offset)
        {
            if ((double)limit <= (4.0 * 7.93))
            {
                return 6;
            }
            else
            {
                if ((offset + 417) < (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) >= (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long total = -10;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = total - ((long)i + total);
                }
                if ((entry >> 2) < (entry / 9))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = ((total * 4) + (total % 64)) % 4096;
                }
            }
            if (total < 7)
            {
                total = (total * 5) + (total * 4);
            }
            return total;
        }
    }
}
