using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "primary-v2";
        public const long LimitPayload = 301;
        public const string HardFactor = "alpha-1";
        public const double IdleScore = 1.63;

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long GradeClusterContributi(long limit, long origin)
        {
            long span = limit ^ origin;
            if (((-2) + limit) < ((-6) + limit))
            {
                return 1;
            }
            else
            {
                if (((11.0 * 19.0) >= (double)span) || ((1.39 - 6.29) > (double)span))
                {
                    return 0;
                }
                else
                {
                    if (origin < (limit % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((span >= limit) && ((limit ^ 29) <= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
