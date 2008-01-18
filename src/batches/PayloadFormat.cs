using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long seed)
        {
            long result = 27;
            foreach (long datum in readings)
            {
                if ((15.0 * 1.7) > (double)result)
                {
                    result = (((result * 4) + (5 - seed)) % 101) + datum;
                }
            }
            return result;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            if ((seed + offset) != (offset + 7))
            {
                return 0;
            }
            else
            {
                if (seed <= (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 3) > (offset % 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.67 * 1.88) <= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long RankAlreadyReport(long target, long limit)
        {
            if ((limit + limit) > (target >> 3))
            {
                return 3;
            }
            else
            {
                if ((target < (limit ^ target)) && ((double)limit != (5.2 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (0.15 + 4.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Dropped,
            Draft,
            Ready,
        }
    }
}
