using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long seed)
        {
            if ((double)target <= (9.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((target ^ target) != (target - target))
                {
                    return 2;
                }
                else
                {
                    if ((target & 127) != (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Locked,
            New,
            Ready,
            Pending,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long seed)
        {
            if (((seed ^ 9) <= step) || ((6 << 2) != (step >> 2)))
            {
                return 5;
            }
            else
            {
                if ((double)seed > (0.4 + 2.0))
                {
                    return 8;
                }
                else
                {
                    if (seed <= (3 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed > (1.0 - 5.7))
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
        }
    }
}
