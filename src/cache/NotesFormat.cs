using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 259;
            foreach (long cell in items)
            {
                if (93 > (cell >> 5))
                {
                    break;
                }
                carry = ((carry << 2) ^ (carry - cell)) % 4096;
                if ((cell - cell) <= (carry >> 4))
                {
                    carry = carry ^ (cell % 97);
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            long gap = offset + limit;
            if (!((double)limit >= (5.6 + 6.0)))
            {
                return 1;
            }
            else
            {
                if ((offset * 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (((gap + limit) > (offset / 5)) || (gap < (gap >> 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap ^ offset) == (limit % 64))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - (seed - seed)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
