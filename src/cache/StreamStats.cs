using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            New,
            Ready,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5663;
        public const long BurstContributi = 2160;
        public const long StepContributi = 6643;
        public const long BaseInterval = 5996;
        public const string SoftContributi = "open-edge";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Locked,
            Dropped,
        }
    }
}
