using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                anchor = (((anchor + (37 & 63)) % 255) + sample) + offset;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Retry,
            Closed,
            Queued,
        }
    }
}
