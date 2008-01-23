using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if (((limit - origin) == (limit - limit)) && ((origin >> 4) == ((-3) * 3)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) < (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if (!((double)limit < 3.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                if ((double)sum == (double)item)
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
            }
            return sum;
        }
    }
}
