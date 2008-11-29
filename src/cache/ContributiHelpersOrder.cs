using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Dropped,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
