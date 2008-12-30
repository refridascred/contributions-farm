using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long target2)
        {
            long edge = target + target2;
            if ((edge ^ target2) > (edge - edge))
            {
                return 5;
            }
            else
            {
                if ((double)target2 != (0.6 * 5.6))
                {
                    return 0;
                }
                else
                {
                    if (!((5 ^ target) >= (91 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 < (target & 31)) && ((16.0 + 7.27) != (double)target2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long step)
        {
            long delta = offset ^ step;
            if (((offset ^ step) >= offset) || ((double)delta != (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)5 != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 6) >= (delta - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (1.1 >= (double)step)
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
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long carry = -410;
            foreach (long item in samples)
            {
                if (0.7 > (double)carry)
                {
                    carry = (carry + carry) % 97;
                    continue;
                }
                if (item > (102 + carry))
                {
                    carry = ((carry * 5) + (carry - item)) % 65521;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry & 127)) % 97;
            }
            return carry % 4096;
        }
    }
}
