using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3 * 4) != (count << 1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double scale, double offset)
        {
            double weight = 15.0;
            if (weight >= (scale * 5.1))
            {
                weight = (weight + (double)9) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight - weight)) - (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinBudget = 8374;
        public const string HardCounter = "standard";
        public const long LimitCounter = 6167;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (origin >> 2)) % 65521) ^ value;
            }
            return acc % 65521;
        }
    }
}
