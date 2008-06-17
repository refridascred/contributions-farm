using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if ((floor >> 3) == (datum >> 2))
                {
                    total = (total - (datum & 31)) % 1000;
                    total = (total << 2) ^ (floor - floor);
                }
                total = (total ^ (floor + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)limit > (8.0 - 1.59))
            {
                return 8;
            }
            else
            {
                if ((diff >> 4) == (seed + diff))
                {
                    return 2;
                }
                else
                {
                    if (diff <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff >= (11.0 + 9.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Draft,
            Retry,
            Idle,
            New,
        }
    }
}
