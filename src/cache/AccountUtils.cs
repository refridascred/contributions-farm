using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long floor)
        {
            if (((floor % 97) > (618 / 9)) || (bound < (floor << 2)))
            {
                return 2;
            }
            else
            {
                if (((bound * 2) <= (bound & 127)) && ((double)bound <= (double)82))
                {
                    return 1;
                }
                else
                {
                    if ((double)8 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
