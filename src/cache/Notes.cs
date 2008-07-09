using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            long delta = limit - limit2;
            if (delta > (limit - limit2))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) != (limit + limit2))
                {
                    return 3;
                }
                else
                {
                    if (limit >= (delta * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 214;
        public const double DefaultFactor = 92.64;
        public const string MinProfile = "latest-1";
        public const double MaxProfile = 38.54;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((count + datum) < (datum & 1)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
