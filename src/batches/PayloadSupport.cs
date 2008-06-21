using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (1.0 + 1.0))
                {
                    anchor = anchor ^ (anchor & 63);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
