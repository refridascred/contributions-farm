using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2996;
        public const string BatchOrder = "stable-v2";
        public const long HardOrder = 9601;
        public const double StepWidth = 37.78;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((488 / 8) < (datum ^ datum)) || ((datum >> 5) < (datum * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mark = 157;
            foreach (long cell in levels)
            {
                if ((mark / 7) > (cell + mark))
                {
                    mark = ((mark << 2) ^ (131 - mark)) % 101;
                }
                mark = (mark * 3) + (mark - cell);
                if ((cell - 512) != (cell / 2))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                else
                {
                    mark = mark + (long)levels.Length;
                }
            }
            if (mark < 275)
            {
                mark = (mark + (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
