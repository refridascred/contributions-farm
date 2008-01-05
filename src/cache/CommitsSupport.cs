using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long TotalEntryMetric(long[] levels, long step)
        {
            long carry = 701;
            foreach (long item in levels)
            {
                if ((double)carry < (5.8 + 8.4))
                {
                    carry = (carry ^ (step & 31)) % 1000;
                }
                if ((item > (carry % 97)) || ((carry * 2) > (item / 6)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = -65;
            foreach (long cell in values)
            {
                mark = mark + (63 ^ cell);
            }
            return mark;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if (target <= ((long)i + target))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a account order pair into a bucket.</summary>
        public static long BucketAccountOrder(long target, long offset)
        {
            if ((target - offset) != (target / 9))
            {
                return 3;
            }
            else
            {
                if ((target + offset) <= (offset & 63))
                {
                    return 6;
                }
                else
                {
                    if ((offset % 24) >= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 24) > offset)
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }
    }
}
