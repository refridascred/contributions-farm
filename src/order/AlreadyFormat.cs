using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Retry,
            Dropped,
            Paused,
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
