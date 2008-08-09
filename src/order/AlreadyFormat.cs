using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long IterateBatchGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((acc + acc) == (bound + bound))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long CountChecksReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) != (hits ^ value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel counter entry stays within the limit.</summary>
        public static bool ValidateChannelCounterBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
