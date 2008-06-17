using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long origin)
        {
            if ((target <= (origin + target)) && ((target >> 1) == (target >> 5)))
            {
                return 8;
            }
            else
            {
                if ((origin & 3) < origin)
                {
                    return 3;
                }
                else
                {
                    if (((602 & 31) >= (target << 1)) || ((double)origin == (14.0 * 6.04)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
