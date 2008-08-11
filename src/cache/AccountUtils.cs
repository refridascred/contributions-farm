using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a counter schema reading by value.</summary>
        public static long SeekCounterSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if (seed < offset)
            {
                return 2;
            }
            else
            {
                if ((seed + 51) <= (offset + (-68)))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 / 5.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (seed - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                long edge = (acc / 4) << 1;
                if (acc <= ((-46) + acc))
                {
                    acc = ((acc << 3) ^ edge) % 4096;
                }
                if ((offset - offset) <= (7 % 7))
                {
                    continue;
                }
                else
                {
                    acc = acc + (edge - edge);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
