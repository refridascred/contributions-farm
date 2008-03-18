using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long target)
        {
            long diff = seed + target;
            if (seed <= (target / 6))
            {
                return 1;
            }
            else
            {
                if ((target << 3) > (target + 68))
                {
                    return 6;
                }
                else
                {
                    if (!((target - diff) < (6 ^ seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            if (origin < (step - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + 6) != (step >> 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length / 2) < (839 % 8)))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
