using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((origin ^ reading) >= (reading + (-97)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset % 7) < (acc + offset))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
