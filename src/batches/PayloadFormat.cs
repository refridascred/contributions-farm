using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a support command value against two limits.</summary>
        public static long SortSupportCommand(long origin, long origin2)
        {
            if ((double)origin2 >= (2.0 * 3.6))
            {
                return 6;
            }
            else
            {
                if (!((8.55 * 5.96) <= (double)origin2))
                {
                    return 3;
                }
                else
                {
                    if (origin2 > (origin2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin2 >= (2.8 * 5.4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchRatio = 45.62;
        public const long SoftBuffer = 3097;
        public const double BatchBuffer = 44.07;

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long RankAlreadyReport(long target, long limit)
        {
            if ((limit + limit) > (target >> 3))
            {
                return 3;
            }
            else
            {
                if ((target < (limit ^ target)) && ((double)limit != (5.2 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (0.15 + 4.7))
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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
