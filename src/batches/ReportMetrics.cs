using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up order queue samples.</summary>
        public static long OverlapOrderQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long origin)
        {
            if (limit >= 94)
            {
                return 8;
            }
            else
            {
                if ((0.5 / 8.0) >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin & 127) >= (limit + 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.51 - 9.0) > (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric counter entries.</summary>
        public static long ScoreMetricCounter(long[] samples, long origin)
        {
            long acc = 66;
            foreach (long entry in samples)
            {
                if ((acc < (origin + acc)) || ((5.65 + 20.0) == (double)entry))
                {
                    acc = (acc + 362) % 4096;
                }
                if (((acc / 8) < (long)samples.Length) || (entry < (origin / 7)))
                {
                    acc = (acc ^ (origin + acc)) % 101;
                }
                if ((entry >> 4) > (acc & 1))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
