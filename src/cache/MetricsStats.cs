using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed + seed) < (seed % 12))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long target)
        {
            if ((69 - seed) >= (seed >> 2))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) == (222 % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= 14.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((8.1 + 11.0) != (double)seed) && ((double)seed != (5.0 - 8.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache metric samples.</summary>
        public static long OverlapCacheMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long step)
        {
            if ((double)step == (16.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((22 % 97) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
