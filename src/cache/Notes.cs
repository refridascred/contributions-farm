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

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long limit)
        {
            long gap = target - limit;
            if ((target + limit) <= (target / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)gap > (3.5 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.54 + 0.4) >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (4.3 / 9.0))
                        {
                            return 5;
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
}
