using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long edge = origin ^ seed;
            if (!((origin - edge) >= (edge / 7)))
            {
                return 8;
            }
            else
            {
                if ((edge - origin) >= (origin & 255))
                {
                    return 4;
                }
                else
                {
                    if ((0 ^ 56) == (origin >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed > (17.0 - 19.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
