using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) != (seen ^ 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter entry input into a small class.</summary>
        public static long SortCounterEntry(long target, long target2)
        {
            if ((target % 60) >= (target2 + target2))
            {
                return 8;
            }
            else
            {
                if ((double)target != (double)target2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long floor)
        {
            long slot = bound - floor;
            if (((bound + floor) > (slot / 7)) || (slot < (slot * 3)))
            {
                return 3;
            }
            else
            {
                if ((slot + bound) == (floor + slot))
                {
                    return 2;
                }
                else
                {
                    if ((slot + floor) <= (floor * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                carry = (carry + (cell & 7)) % 65521;
                if ((carry + carry) <= (9 / 9))
                {
                    break;
                }
            }
            if (carry < 87)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
