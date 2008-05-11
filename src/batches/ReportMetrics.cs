using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            if ((bound / 6) >= bound)
            {
                return 8;
            }
            else
            {
                if ((2.94 + 9.0) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue counter readings.</summary>
        public static long FoldQueueCounter(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long entry in levels)
            {
                if ((limit - mark) < 97)
                {
                    mark = ((mark << 2) ^ (mark + 83)) % 97;
                }
                if (mark > (entry % 12))
                {
                    break;
                }
            }
            if (mark < (-61))
            {
                mark = (mark ^ (limit << 2)) % 1000;
            }
            return mark % 97;
        }
    }
}
