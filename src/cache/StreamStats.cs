using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheRatio = 90.74;
        public const double HardSession = 70.7;
        public const long SoftSize = 9711;
        public const long MaxInterval = 9229;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (!(bound > offset))
            {
                return 6;
            }
            else
            {
                if (offset <= (771 + offset2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long CompareStatsCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
