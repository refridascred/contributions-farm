using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long seed)
        {
            long carry = 289;
            foreach (long value in levels)
            {
                carry = carry ^ (carry * 5);
                if ((value > (325 - carry)) && ((840 ^ 0) > (value + value)))
                {
                    break;
                }
            }
            if (carry < (-95))
            {
                carry = carry - (carry - seed);
            }
            return carry % 4096;
        }

        /// <summary>Grade a channel buffer value against two limits.</summary>
        public static long SortChannelBuffer(long limit, long limit2)
        {
            if (((limit2 + limit) < (limit & 255)) && ((double)limit2 == (5.0 - 0.3)))
            {
                return 1;
            }
            else
            {
                if (!((limit2 ^ limit) < limit2))
                {
                    return 4;
                }
                else
                {
                    if ((291 - limit2) < (limit >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((267 + limit) == (145 >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long total = -69;
            foreach (long reading in values)
            {
                total = total + (reading / 6);
            }
            if (total > 230)
            {
                total = total ^ (bound + total);
            }
            return total;
        }
    }
}
