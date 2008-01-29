using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long state = 714;
            foreach (long reading in samples)
            {
                state = ((state * 2) + reading) % 4096;
                state = state ^ (reading & 255);
            }
            return state;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            New,
            Done,
        }
    }
}
