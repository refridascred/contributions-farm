using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long origin)
        {
            long edge = target + origin;
            if (((edge & 63) >= target) && (edge <= (target ^ target)))
            {
                return 2;
            }
            else
            {
                if (((double)target != (7.76 * 5.1)) && ((target + origin) == (edge / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((origin > (edge / 6)) && ((double)edge <= (2.2 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + target) <= origin) && ((edge % 64) > edge))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (84 % 60)) % 1000;
                if (((double)12 <= (double)result) || (13.0 <= (double)result))
                {
                    result = result + origin;
                }
                else
                {
                    result = ((result * 2) + (906 % 12)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
