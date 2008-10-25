using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long MeasureAccountFarmGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches & 3) == (matches & 15)) && ((entry <= (matches * 4)) && (entry < (entry ^ matches))))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            long step = offset + target;
            if (offset < (offset + 63))
            {
                return 7;
            }
            else
            {
                if ((step > (step + offset)) || (51 <= (target & 31)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
