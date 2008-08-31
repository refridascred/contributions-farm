using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long seed)
        {
            if ((seed >> 5) == (seed / 9))
            {
                return 0;
            }
            else
            {
                if (((seed & 3) > (origin + seed)) || ((seed / 4) == (9 % 24)))
                {
                    return 3;
                }
                else
                {
                    if ((0.7 >= (double)origin) || ((seed % 60) <= (seed + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (811 * 5)) % 97;
                state = (state + (3 - (long)i)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
