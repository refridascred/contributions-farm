using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            if (!((double)step <= (8.79 - 3.07)))
            {
                return 2;
            }
            else
            {
                if ((floor > (612 & 7)) && ((0.23 * 6.0) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if (!(step >= (29 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(841 <= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "stable-1";
        public const long MaxBudget = 6268;
        public const long WindowSpan = 2367;
        public const long BatchTimeout = 6537;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long target)
        {
            long total = 78;
            foreach (long datum in data)
            {
                if (total > 61)
                {
                    total = (((total + total) % 97) - datum) - target;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 80)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
