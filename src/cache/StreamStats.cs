using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)7 < (double)reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((state & 7) == ((long)i + state)) || ((seed ^ seed) > (seed % 12)))
                {
                    state = ((state << 2) ^ state) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
