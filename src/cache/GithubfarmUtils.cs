using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a command window value against two limits.</summary>
        public static long BucketCommandWindow(long seed, long offset)
        {
            long lane = seed + offset;
            if ((double)lane < (9.0 + 17.0))
            {
                return 3;
            }
            else
            {
                if ((1.25 - 8.4) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (!((seed - lane) >= (1 >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.35 - 17.0) < (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits - item) == (hits ^ 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long result = 0;
            foreach (long item in readings)
            {
                result = (result + (result + item)) % 101;
                if ((4.0 <= (double)item) || (result >= 890))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 3) + ((-983) + result)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
