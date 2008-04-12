using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 33.14;
        public const long CacheInterval = 1681;
        public const string MinGraph = "stable-edge";

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long MeasureQueueBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((bound - (-10)) != (reading & 255)) && ((4.86 + 8.59) > (double)count)) && !((count - count) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long SeekReportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
