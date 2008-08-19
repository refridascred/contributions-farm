using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long bound)
        {
            long offset = limit + bound;
            if (bound >= limit)
            {
                return 4;
            }
            else
            {
                if (((bound + offset) <= limit) && ((double)offset >= (5.0 + 7.0)))
                {
                    return 3;
                }
                else
                {
                    if ((bound * 4) == (9 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((745 ^ bound) == (bound << 1)) && ((double)37 > (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= ((-42) << 2))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
