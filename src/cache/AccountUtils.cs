using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 63) == ((long)i + (long)i))
                {
                    score = (score << 3) ^ (offset >> 5);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            if ((origin + floor) > origin)
            {
                return 8;
            }
            else
            {
                if ((80 + origin) > (7 & 31))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (floor >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor <= (floor - floor)) || ((origin - floor) <= (origin ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
