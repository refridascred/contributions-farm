using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a stats schema sample.</summary>
        public static long LocateStatsSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            if (bound <= origin)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (163 % 97))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (7.5 * 6.22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.6 - 13.0) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((5.3 - 2.0) == (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
