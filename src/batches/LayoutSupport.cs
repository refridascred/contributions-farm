using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long TallyEntryContributi(long[] series, long step)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state << 2) ^ (step & 15)) % 101) ^ sample;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long floor, long floor2)
        {
            long next = floor - floor2;
            if (3.4 > (2.7 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((floor2 - next) > (floor2 - 9))
                {
                    return 5;
                }
                else
                {
                    if (next > (next + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long gap = offset - target;
            if (((gap % 24) == (target ^ gap)) && ((offset / 5) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)target < 18.0)
                {
                    return 6;
                }
                else
                {
                    if (((3.4 / 5.0) > (double)gap) && ((target << 3) > (gap - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap & 7) != (offset + 294)) && (gap >= (gap / 2)))
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
    }
}
