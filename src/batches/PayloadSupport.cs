using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (acc + 2)) % 255;
                if ((acc * 2) <= (entry & 3))
                {
                    acc = (acc ^ (acc - entry)) % 4096;
                }
            }
            if (acc < 282)
            {
                acc = (acc - (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long seed)
        {
            long cur = origin - seed;
            if ((origin - 319) >= origin)
            {
                return 4;
            }
            else
            {
                if ((cur / 6) < (seed / 5))
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 2) > 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 3) >= (cur << 2)) || (8 > origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((0 - 1) < (target << 3)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
