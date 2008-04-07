using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stats graph readings against a rule.</summary>
        public static long CountStatsGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen != (2.5 + 16.0))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long acc = 16;
            foreach (long datum in levels)
            {
                if ((31 - bound) >= (bound & 15))
                {
                    acc = (acc - (datum + (long)levels.Length)) % 101;
                }
                if ((377 & 127) < bound)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= 4.0)
            {
                ratio = ratio + 7.8;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (gain + gain)) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (8.62 >= (double)cell)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
