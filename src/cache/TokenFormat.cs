using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((-655) + mark) >= (long)i)
                {
                    mark = (mark * 5) + (origin - mark);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank layout session input into a small class.</summary>
        public static long ClassifyLayoutSession(long offset, long step)
        {
            if ((33 << 3) < (step + 652))
            {
                return 6;
            }
            else
            {
                if ((double)step < (9.0 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (16.0 / 5.0)) && ((step ^ 729) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 - 20.0) >= (double)step)
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
        }
    }
}
