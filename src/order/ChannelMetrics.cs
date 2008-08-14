using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (anchor + 36))
                {
                    anchor = (anchor + (reading & 15)) % 4096;
                    anchor = anchor - (seed * 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (460 ^ reading)) % 65521;
                    anchor = (anchor ^ (seed * 3)) % 65521;
                }
                anchor = (anchor + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
