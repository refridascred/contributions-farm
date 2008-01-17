using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank graph githubfarm input into a small class.</summary>
        public static long GradeGraphGithubfarm(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)bound != (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step <= (3.8 - 9.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 1) != (80 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ step) <= (floor ^ 91)) && (bound >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long bound)
        {
            if ((7.0 < (double)seed) && ((seed * 5) != (9 - bound)))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (11.0 * 2.8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long floor)
        {
            long bound = origin - floor;
            if (((-737) << 3) != (floor ^ bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next support editor value from a seed.</summary>
        public static long DeriveSupportEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if ((result / 4) >= (step ^ step))
                {
                    result = (result - step) % 65521;
                }
                result = (result ^ (step % 10)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
