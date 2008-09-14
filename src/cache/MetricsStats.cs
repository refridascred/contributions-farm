using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long bound)
        {
            long total = 575;
            foreach (long reading in items)
            {
                if ((4.7 / 4.0) <= (double)total)
                {
                    total = (((total << 2) ^ (bound * 2)) % 65521) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report cluster readings.</summary>
        public static long TotalReportCluster(long[] samples, long floor)
        {
            long state = 28;
            foreach (long datum in samples)
            {
                if (((floor * 5) > floor) || ((double)5 <= (double)state))
                {
                    state = (state - (state ^ floor)) - datum;
                }
                if (!((state / 8) < (state >> 3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
