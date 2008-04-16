using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long slot = target + limit;
            if (((slot + 6) > slot) || ((target % 10) <= slot))
            {
                return 5;
            }
            else
            {
                if ((slot <= (slot + limit)) || ((target % 2) != (6 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((slot ^ limit) < 6)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18 >> 5) <= (3 + slot)) || ((limit >> 4) > target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepDepth = 12.36;
        public const long CacheSize = 7836;
        public const long WindowBudget = 550;
        public const long WindowNotes = 4593;
        public const long HardCount = 8611;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                long prev = ((long)i / 6) + (floor >> 2);
                carry = (carry ^ prev) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
