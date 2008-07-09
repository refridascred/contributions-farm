using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long origin)
        {
            long step = floor - origin;
            if (!((origin - floor) != (floor - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin << 1) < (origin - 64))
                {
                    return 6;
                }
                else
                {
                    if ((4.75 * 2.0) == (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + origin) == (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record account value against two limits.</summary>
        public static long BucketRecordAccount(long limit, long floor)
        {
            if ((1.0 / 3.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((limit >= 448) || ((floor + floor) > (limit << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 5) >= (4 + 61))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long bound, long target)
        {
            long edge = bound ^ target;
            if ((bound / 3) <= (43 + target))
            {
                return 1;
            }
            else
            {
                if ((target + edge) < (bound & 63))
                {
                    return 7;
                }
                else
                {
                    if ((483 + target) >= (target << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (56 >= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxTimeout = "stable-1";
        public const long CacheNotes = 9784;
        public const long CacheSize = 6479;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Active,
            Stale,
            Closed,
            Dropped,
        }
    }
}
