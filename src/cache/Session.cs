using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ 42;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long GradeContributiRoute(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (floor2 > (delta >> 2))
            {
                return 7;
            }
            else
            {
                if (floor <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (double)42)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor2 != (3.17 / 6.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                state = (state - (reading << 3)) % 1000;
            }
            return state;
        }
    }
}
