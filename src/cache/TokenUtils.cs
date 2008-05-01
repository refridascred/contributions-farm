using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((7.07 + 2.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) < (origin + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 - 1.4) != (double)origin)
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
    }
}
