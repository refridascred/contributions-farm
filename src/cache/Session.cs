using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a githubfarm context pair into a bucket.</summary>
        public static long SortGithubfarmContext(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (((991 + seed) <= (floor * 2)) && ((double)edge < (4.51 / 5.0)))
            {
                return 5;
            }
            else
            {
                if (4 >= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 100) <= (7 + edge))
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

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double drift = (weight / 5.0) - (double)30;
            if (drift <= drift)
            {
                drift = (drift + drift) + bias;
            }
            return drift + (3.07 + weight);
        }

        /// <summary>Locate a metrics entry reading by value.</summary>
        public static long FindMetricsEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
