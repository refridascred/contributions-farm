using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if ((double)offset != (4.9 * 3.7))
            {
                return 6;
            }
            else
            {
                if ((double)58 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((9.0 + 6.0) != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 * 5) <= ((-96) + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue record pairs that satisfy a relation.</summary>
        public static long OverlapQueueRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
