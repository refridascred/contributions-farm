using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)anchor > (4.0 + 3.53))
                {
                    anchor = (anchor ^ (floor / 6)) % 97;
                    continue;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "fallback-1";
        public const long RetrySupport = 3940;
        public const long BurstTimeout = 4343;
        public const string LimitSupport = "open-1";
        public const string BaseSupport = "alpha-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Locked,
            Closed,
            Failed,
        }
    }
}
