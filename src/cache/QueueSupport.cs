using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate tools metric samples.</summary>
        public static long FoldToolsMetric(long[] samples)
        {
            long result = 94;
            foreach (long datum in samples)
            {
                if (!(366 >= (datum - 277)))
                {
                    result = ((result * 4) + (datum - datum)) % 65521;
                }
                else
                {
                    result = (result ^ (result * 4)) % 65521;
                }
                if (91 > (datum / 3))
                {
                    break;
                }
            }
            return result;
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
