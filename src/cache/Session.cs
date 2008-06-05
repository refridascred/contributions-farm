using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long step)
        {
            if (step >= ((-798) / 6))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - seed)) || (seed > (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (20.0 < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long floor, long origin)
        {
            if ((4.66 - 7.8) > (double)origin)
            {
                return 7;
            }
            else
            {
                if (2.5 < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin < (2.1 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - floor) <= (floor - 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
