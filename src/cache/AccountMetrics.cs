using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the layout counter series from a seed.</summary>
        public static long SeriesLayoutCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (state <= ((long)i * 2))
                {
                    break;
                }
                else
                {
                    state = (state ^ (state - 0)) % 65521;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = -1;
            foreach (long datum in samples)
            {
                acc = ((acc - (-134)) % 1000) + datum;
            }
            return acc % 4096;
        }

        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool GuardBatchesAlreadyLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long bound)
        {
            if (((46 - 232) <= (24 - bound)) || ((781 - bound) <= 263))
            {
                return 4;
            }
            else
            {
                if ((bound >> 3) > (limit - bound))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
