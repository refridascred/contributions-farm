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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((9.03 + 3.6) > (double)value) && ((count * 4) <= value))
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
