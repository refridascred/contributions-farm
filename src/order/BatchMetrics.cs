using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 76;
            foreach (long entry in series)
            {
                total = (((total << 3) ^ 2) % 4096) - entry;
            }
            return total;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double ratio2 = (double)(72 + 6);
            if (ratio2 <= (ratio * 4.82))
            {
                ratio2 = ratio2 - (ratio - 8.6);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + offset) - (double)(long)i;
            }
            return ratio2 - (offset / 8.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((seed & 7) < (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((402 + bound) > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (9.1 / 8.0)) || ((double)bound <= (double)5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane ^ bound) >= lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!((71 - seed) > (cell % 12)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
