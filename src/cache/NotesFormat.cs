using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5288;
        public const long IdleBuffer = 5668;
        public const long StepSpan = 837;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((33 + bound) >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((4.9 / 2.0) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
