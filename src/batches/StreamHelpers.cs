using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long total = 671;
            foreach (long value in series)
            {
                if ((value + value) < (total * 2))
                {
                    total = total ^ (total + total);
                }
                else
                {
                    total = total ^ 3;
                }
                if ((value - value) < (value + value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of channel record readings.</summary>
        public static long CombineChannelRecord(long[] data, long limit)
        {
            long sum = -39;
            foreach (long cell in data)
            {
                if ((cell > (sum & 3)) && (cell >= (sum - sum)))
                {
                    sum = ((sum << 2) ^ (limit ^ cell)) % 97;
                }
                if (!(sum < limit))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long SeriesBatchCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
