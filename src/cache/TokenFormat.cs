using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long StepClusterBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long BucketRouteChecks(long bound, long step)
        {
            if ((bound / 2) < (bound - step))
            {
                return 4;
            }
            else
            {
                if ((step + step) > (0 - bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
