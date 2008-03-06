using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((double)span >= (6.3 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (7.9 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if (!(984 < (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span >> 1) < (span - 227))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two farm stats measurements.</summary>
        public static double ProjectFarmStats(double scale, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)168)
            {
                ratio = (ratio - (double)8) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio * 5.88)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
