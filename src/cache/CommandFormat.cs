using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first report order entry that matches the target.</summary>
        public static long FindReportOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((step - 44) >= sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stream cache entries that pass the check.</summary>
        public static long TallyStreamCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((9.19 + 4.8) == (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
