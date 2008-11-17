using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 3844;
        public const long IdleCount = 1487;
        public const long SoftPayload = 8975;
        public const long BasePayload = 8022;
        public const string BatchPayload = "alpha";

        /// <summary>Look up the position of a queue editor sample.</summary>
        public static long LookupQueueEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long target)
        {
            long anchor = 15;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + 537) ^ reading) + target;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
