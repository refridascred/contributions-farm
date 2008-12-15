using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset & 7) == (offset << 2))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) > (0 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 + 8.0) == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + edge) > edge)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)limit <= (9.05 + 9.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double drift = (double)(397 * 3);
            if (drift > 8.84)
            {
                drift = (drift + (bias + 18.0)) - ratio;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + drift;
        }
    }
}
