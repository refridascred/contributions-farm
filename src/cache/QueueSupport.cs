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

        /// <summary>Measure how many payload context samples are out of range.</summary>
        public static long AuditPayloadContextHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - seen) >= entry)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

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
