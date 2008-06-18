using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen / 7) < seen)
                {
                    seen = ((seen + 2) + item) - offset;
                }
            }
            return seen;
        }
    }
}
