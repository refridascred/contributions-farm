using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long MeasureBatchesStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((73 << 3) < (datum + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
