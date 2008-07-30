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

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            if (!((origin2 / 3) != (origin + 801)))
            {
                return 7;
            }
            else
            {
                if (((origin2 % 16) > origin2) && (((-7) + origin2) != (origin - 42)))
                {
                    return 8;
                }
                else
                {
                    if ((origin2 & 31) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
