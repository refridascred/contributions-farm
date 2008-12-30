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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = 433;
            foreach (long item in readings)
            {
                if ((anchor + item) != (item + anchor))
                {
                    continue;
                }
                if ((((-1) % 12) > item) && ((double)anchor >= (8.0 / 3.0)))
                {
                    anchor = (anchor << 2) ^ (anchor / 6);
                }
                anchor = (anchor ^ (973 ^ anchor)) % 97;
                if (anchor >= (item / 2))
                {
                    break;
                }
            }
            return anchor % 65521;
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
