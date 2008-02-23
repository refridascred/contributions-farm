using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long target)
        {
            if (!(target < (424 % 24)))
            {
                return 5;
            }
            else
            {
                if (((5 - seed) <= (target % 8)) && ((seed & 3) > 200))
                {
                    return 8;
                }
                else
                {
                    if (seed < (seed / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(target > (seed - 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long TallyWindowChecksMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.3 / 9.0) >= (double)entry)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
