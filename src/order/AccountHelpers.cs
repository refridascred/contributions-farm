using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits order entries that pass the check.</summary>
        public static long AuditCommitsOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats schema samples.</summary>
        public static long FoldStatsSchema(long[] readings)
        {
            long acc = 12;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ datum) % 65521;
                if ((acc >> 4) <= ((-866) + datum))
                {
                    acc = acc - (datum / 8);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
