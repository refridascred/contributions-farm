using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((6.43 * 11.0) >= (double)value)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a window buffer pair into a bucket.</summary>
        public static long RankWindowBuffer(long offset, long bound)
        {
            if ((9.6 + 7.9) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3005;
        public const double DefaultCount = 79.84;
        public const double WindowBuffer = 46.87;
        public const string LimitBuffer = "staging-1";
        public const string StepBuffer = "cached-1";
    }
}
