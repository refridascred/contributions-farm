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

        /// <summary>Combine cache already values into a single score.</summary>
        public static long TallyCacheAlready(long[] readings)
        {
            long carry = 67;
            foreach (long cell in readings)
            {
                if (((double)cell > (2.48 / 6.0)) || (carry >= (cell % 64)))
                {
                    carry = (carry + (carry * 2)) % 1000;
                }
            }
            return carry % 97;
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
