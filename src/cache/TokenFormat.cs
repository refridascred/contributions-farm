using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) == (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long origin, long limit)
        {
            if ((19.0 < (double)origin) && ((double)origin >= 7.41))
            {
                return 2;
            }
            else
            {
                if ((988 % 2) >= origin)
                {
                    return 6;
                }
                else
                {
                    if (((0 + origin) < (62 / 2)) || ((limit + origin) > origin))
                    {
                        return 5;
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
