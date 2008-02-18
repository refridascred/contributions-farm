using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long SeriesBufferToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((result << 3) >= seed)
                {
                    result = result ^ result;
                    result = (result ^ result) % 4096;
                }
                if ((1.97 - 1.65) == (double)result)
                {
                    result = result - (137 / 4);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ (origin + anchor)) % 101;
                anchor = (anchor * 5) + (476 << 2);
                anchor = anchor + (anchor + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
