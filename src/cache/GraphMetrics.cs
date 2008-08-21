using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((double)(long)items.Length < (7.0 - 4.0)) && (matches >= (4 << 3))) && ((matches / 7) < (value + value)))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) < (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches / 5) == (matches & 7))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Failed,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Done,
            Pending,
            Synced,
            New,
        }
    }
}
