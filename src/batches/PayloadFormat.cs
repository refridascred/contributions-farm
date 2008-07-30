using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long seed)
        {
            if ((floor + seed) != (3 % 100))
            {
                return 3;
            }
            else
            {
                if (((floor >> 3) >= (floor - seed)) && ((floor & 255) <= (floor >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor == (1.36 * 7.7))
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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a record account sample.</summary>
        public static long LocateRecordAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
