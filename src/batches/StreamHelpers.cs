using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "primary";
        public const long BatchCommits = 6043;
        public const long MaxCommits = 7269;

        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long FoldBufferStream(long[] readings, long seed)
        {
            long mark = 405;
            foreach (long entry in readings)
            {
                if ((seed % 60) >= (entry & 31))
                {
                    mark = ((mark << 3) ^ (mark / 3)) % 4096;
                }
                mark = ((mark << 3) ^ (88 ^ mark)) % 1000;
            }
            return mark;
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
