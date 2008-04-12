using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            long slot = floor + bound;
            if (bound < (3 / 5))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) != (5 - bound))
                {
                    return 6;
                }
                else
                {
                    if (6 > slot)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((12.0 + 7.2) >= (double)reading)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
