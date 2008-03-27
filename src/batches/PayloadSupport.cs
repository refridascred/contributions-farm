using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long bound)
        {
            if ((4.3 * 7.65) == (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((2.0 / 2.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) == (bound & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit ^ bound) > 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter commits counter forward.</summary>
        public static long SeriesFilterCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                score = score - ((long)i / 7);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score + (0 << 3)) % 1000) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
