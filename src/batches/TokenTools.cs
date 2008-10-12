using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((mark % 2) != (limit - (long)i))
                {
                    mark = ((mark * 3) + (2 / 7)) % 1000;
                }
                mark = (mark + (limit / 5)) % 255;
                mark = (mark ^ (5 / 5)) % 97;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((7.0 * 1.5) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((3.19 / 2.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((floor >> 3) != (floor << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
