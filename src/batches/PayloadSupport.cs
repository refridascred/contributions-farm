using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long target)
        {
            if ((4.35 / 9.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (!(5.7 < (double)target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double rate = bias;
            if (rate >= 14.0)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate + (6.5 * 4.9);
            }
            return rate - (double)215;
        }

        /// <summary>Compare every pair of record support readings.</summary>
        public static long PairRecordSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
