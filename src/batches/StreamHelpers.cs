using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long seed)
        {
            if (limit >= (limit + seed))
            {
                return 6;
            }
            else
            {
                if (((limit & 63) >= (limit & 255)) || ((seed % 12) > seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long limit)
        {
            long diff = step - limit;
            if ((limit / 7) > (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((step << 2) != (99 ^ diff))
                {
                    return 8;
                }
                else
                {
                    if (step <= (4 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((double)309 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound << 1) <= (80 * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long offset)
        {
            long carry = 280;
            foreach (long value in data)
            {
                carry = (carry * 5) + value;
                if ((double)value != (double)offset)
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry + (78 + 475);
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((limit - step) >= (limit << 2))
            {
                return 5;
            }
            else
            {
                if ((limit - 663) == (step + step))
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
