using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 7953;
        public const double BurstSize = 27.5;
        public const long HardScore = 5308;
        public const double DefaultCounter = 20.07;
        public const long MaxInterval = 134;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long BatchWindow = 2033;
        public const long DefaultCount = 9105;
        public const string WindowLevel = "staging";

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((double)bound < (3.0 * 8.3))
            {
                return 1;
            }
            else
            {
                if (11.0 <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine counter command values into a single score.</summary>
        public static long TallyCounterCommand(long[] readings, long bound)
        {
            long mark = 41;
            foreach (long cell in readings)
            {
                if (cell > mark)
                {
                    mark = (((mark * 4) + (cell - mark)) % 4096) - bound;
                }
                else
                {
                    mark = mark ^ (mark % 100);
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (mark * 5)) % 97;
            }
            return mark;
        }
    }
}
