using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            long span = seed ^ offset;
            if (((4 - seed) != (offset - (-709))) && ((seed / 9) != (61 << 3)))
            {
                return 2;
            }
            else
            {
                if ((0.8 / 7.0) > (double)span)
                {
                    return 6;
                }
                else
                {
                    if ((span >> 4) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (seed / 2)) && ((40 >> 1) <= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSpan = "local-1";
        public const long MinInterval = 8103;
        public const string HardSize = "open-1";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
