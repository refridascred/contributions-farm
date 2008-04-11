using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long target)
        {
            if (floor <= (target >> 1))
            {
                return 2;
            }
            else
            {
                if (!((double)floor == (double)308))
                {
                    return 8;
                }
                else
                {
                    if ((target - floor) >= (658 >> 1))
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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            long slot = origin - step;
            if (726 > (7 + step))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (4.0 * 5.3))
                {
                    return 0;
                }
                else
                {
                    if ((slot << 1) != (slot & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every schema payload entry stays within the limit.</summary>
        public static bool GuardSchemaPayloadBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
