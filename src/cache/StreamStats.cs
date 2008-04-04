using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches order samples.</summary>
        public static long ScoreBatchesOrder(long[] readings, long bound)
        {
            long carry = -817;
            foreach (long value in readings)
            {
                carry = (carry + (bound - bound)) % 4096;
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 5) + value) % 65521) - (long)i;
                }
                if ((56 % 100) == (bound / 7))
                {
                    carry = carry ^ 494;
                }
                else
                {
                    carry = carry - (carry + value);
                }
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long target)
        {
            long delta = step - target;
            if ((delta & 63) < (step - step))
            {
                return 3;
            }
            else
            {
                if ((delta >> 4) <= delta)
                {
                    return 8;
                }
                else
                {
                    if ((3.3 <= (double)target) && ((step * 2) > (target << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)74)
            {
                scale = scale + span;
            }
            return scale - (weight - span);
        }
    }
}
