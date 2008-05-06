using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((92 ^ matches) > matches) || (matches >= (6 + sample))) && ((double)sample != (double)4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= 8.36)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit batch contributi readings against a rule.</summary>
        public static long MeasureBatchContributiGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((11 ^ datum) != (3 * 5)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(seen < (sample - 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
