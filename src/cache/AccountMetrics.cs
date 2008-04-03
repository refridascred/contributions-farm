using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload layout readings.</summary>
        public static long OverlapPayloadLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a window stream sample.</summary>
        public static long SeekWindowStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            if (!((limit * 4) < (limit / 4)))
            {
                return 5;
            }
            else
            {
                if (((limit >> 5) == (5 % 3)) && ((floor + floor) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + 6) != (floor - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= floor) && ((limit - floor) < (floor - limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
