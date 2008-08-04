using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long step, long limit)
        {
            if ((6.2 * 2.2) >= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit + limit) >= (-2))
                {
                    return 4;
                }
                else
                {
                    if (step > (step & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 3) >= (187 ^ step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((15.0 + 5.0) >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
