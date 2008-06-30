using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long offset)
        {
            long offset2 = target + offset;
            if (!((offset2 + 4) > offset2))
            {
                return 1;
            }
            else
            {
                if ((target >> 3) > (offset * 4))
                {
                    return 0;
                }
                else
                {
                    if ((425 + offset) >= (8 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset2 != (1.9 + 2.44))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
