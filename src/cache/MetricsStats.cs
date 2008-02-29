using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next farm context value.</summary>
        public static double ProjectFarmContext(double rate, double offset)
        {
            double drift = (11.0 + rate) * 8.7;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) - offset;
            }
            return drift + (drift - rate);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally <= (tally / 2)) && (((-1) & 1) > (reading & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if ((261 >> 1) >= (bound & 127))
            {
                return 0;
            }
            else
            {
                if (((bound - 3) < (bound + 651)) && ((seed ^ seed) < (seed + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (6.88 - 5.01))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long ScoreFarmEditor(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = (score - (item - score)) % 1000;
                if (!((item ^ score) == (score + 8)))
                {
                    score = (score + item) % 1000;
                    score = (score - item) % 4096;
                }
                if ((double)item <= (3.79 + 4.21))
                {
                    score = score ^ score;
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
