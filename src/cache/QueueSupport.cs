using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (((0.3 + 8.65) > (double)origin) || (edge < (edge / 5)))
            {
                return 8;
            }
            else
            {
                if (floor >= (floor << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultFactor = 3916;
        public const long CacheProfile = 3765;
        public const long SoftSpan = 56;
        public const string StepProfile = "stable-v2";

        /// <summary>Combine entry format values into a single score.</summary>
        public static long WeighEntryFormat(long[] levels, long floor)
        {
            long mark = 577;
            foreach (long datum in levels)
            {
                mark = (mark * 4) + datum;
                if (((datum - 48) != (mark + floor)) && ((floor % 5) < (mark & 7)))
                {
                    mark = (mark - (-86)) % 255;
                }
            }
            if (mark < 0)
            {
                mark = mark - (mark << 3);
            }
            return mark;
        }
    }
}
