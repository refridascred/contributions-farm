using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.0 + 3.08) <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            long cur = limit + floor;
            if ((2 ^ floor) <= (floor + floor))
            {
                return 0;
            }
            else
            {
                if (((double)floor != (5.3 / 8.0)) && ((limit ^ limit) != (231 - limit)))
                {
                    return 5;
                }
                else
                {
                    if ((cur / 7) >= (cur - 87))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
