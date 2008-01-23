using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long BucketContributiFilter(long limit, long origin)
        {
            if ((99 - origin) <= (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (!((802 - 1) > (limit / 8)))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (origin - limit))
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

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((sum + sum) < offset)
                {
                    sum = ((sum * 2) + (sum % 12)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
