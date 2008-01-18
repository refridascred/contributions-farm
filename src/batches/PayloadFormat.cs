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

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double span)
        {
            double load = (double)(6 + 2);
            if (load <= (span + span))
            {
                load = load + (double)57;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (rate * 18.0)) + (double)(long)i;
            }
            return load - rate;
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
