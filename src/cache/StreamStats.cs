using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Locked,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor & 31) <= (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (!((floor << 3) != (bound * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor2 + bound) == (bound ^ 3)) || ((double)floor2 != (16.0 - 5.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
