using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool VerifyCacheAccountLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a support editor counter forward.</summary>
        public static long RollSupportEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (long)i) % 255;
                if (!((carry + carry) < (limit & 31)))
                {
                    carry = carry + (carry / 5);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate queue contributi samples.</summary>
        public static long TotalQueueContributi(long[] levels)
        {
            long mark = 219;
            foreach (long cell in levels)
            {
                mark = ((mark * 4) + (cell + cell)) % 255;
                if ((double)mark != (0.5 / 7.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
