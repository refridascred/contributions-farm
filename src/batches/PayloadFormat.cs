using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long bound)
        {
            long step2 = step + bound;
            if ((step2 >> 3) <= (step2 * 3))
            {
                return 4;
            }
            else
            {
                if ((step2 + bound) > (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((1.94 * 5.51) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((602 ^ 974) > step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)origin <= (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
