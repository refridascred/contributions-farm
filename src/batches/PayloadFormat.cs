using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long bound, long limit)
        {
            if ((9.0 + 0.72) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((bound & 7) > (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound >= (14.0 * 1.91)) && ((bound >> 2) > (6 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 * 6.19) != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 1) >= ((-5) * 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
