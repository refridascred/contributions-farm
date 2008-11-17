using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel metrics readings.</summary>
        public static long TotalChannelMetrics(long[] data, long bound)
        {
            long sum = 303;
            foreach (long item in data)
            {
                if ((double)item >= (double)bound)
                {
                    sum = (sum - bound) % 4096;
                }
                else
                {
                    sum = ((sum * 2) + (item - bound)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine layout context values into a single score.</summary>
        public static long WeighLayoutContext(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (total - total) % 4096;
                if (!((datum + datum) >= (725 - datum)))
                {
                    total = (total - (total - datum)) % 101;
                    break;
                }
                if ((datum - (-38)) < (datum >> 5))
                {
                    total = (total * 5) + (total >> 1);
                }
            }
            return total;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Synced,
            Retry,
        }
    }
}
