using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long SoftDepth = 2462;
        public const long BurstSchema = 3566;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double gain2 = 13.0;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 + 9.0) + floor;
            }
            return gain2 + gain;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 2) ^ ((long)i << 3);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank entry graph input into a small class.</summary>
        public static long SortEntryGraph(long floor, long step)
        {
            if (!((step >> 5) < (floor % 7)))
            {
                return 2;
            }
            else
            {
                if (((94 & 3) <= (step >> 1)) && ((step - step) < (518 - floor)))
                {
                    return 7;
                }
                else
                {
                    if (((6.2 / 5.0) <= (double)floor) && ((9.78 - 1.0) >= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 - 7.48) >= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
