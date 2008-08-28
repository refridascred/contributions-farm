using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (7.27 + 9.7))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a already channel pair into a bucket.</summary>
        public static long ClassifyAlreadyChannel(long limit, long seed)
        {
            if (!((limit + seed) >= (seed & 3)))
            {
                return 2;
            }
            else
            {
                if (((4.3 + 8.0) >= (double)limit) && ((limit / 4) < (seed * 4)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 2) >= (865 * 5)) && ((44 - (-70)) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels, long origin)
        {
            long score = 94;
            foreach (long datum in levels)
            {
                score = ((score - (score + datum)) % 97) + origin;
            }
            if (score < 83)
            {
                score = (score - (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((4.0 * 13.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - bound) != (9 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((9.26 - 9.89) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 3) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
