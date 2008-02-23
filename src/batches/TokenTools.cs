using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a stream account pair into a bucket.</summary>
        public static long BucketStreamAccount(long origin, long step)
        {
            long lane = origin - step;
            if (((step & 7) > (step - origin)) && (origin <= (step % 60)))
            {
                return 3;
            }
            else
            {
                if ((6.15 * 19.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((origin - step) > (760 ^ lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the stream format series from a seed.</summary>
        public static long SeriesStreamFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + ((long)i << 2)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
