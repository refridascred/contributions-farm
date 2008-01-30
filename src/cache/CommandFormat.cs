using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long state = -10;
            foreach (long cell in items)
            {
                if ((cell >> 2) != (bound % 60))
                {
                    state = state + (cell * 4);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(((57 & 7) < (sample >> 2)) && (tally <= (92 + sample))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultLevel = 85.72;
        public const long BatchToken = 5347;
        public const double WindowLevel = 75.53;
        public const string MinWidth = "fallback-edge";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((step & 63) != (cell & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
