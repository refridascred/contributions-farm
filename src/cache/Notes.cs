using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the support format series from a seed.</summary>
        public static long RollSupportFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] items, long target)
        {
            long total = 39;
            foreach (long datum in items)
            {
                if ((total & 3) >= (datum & 7))
                {
                    total = (total + (total - total)) % 255;
                    break;
                }
                if (((datum << 3) <= target) && ((datum - target) <= (total / 9)))
                {
                    total = (total - 520) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total - total)) % 4096;
                }
                if (datum < (datum + target))
                {
                    total = total ^ (target + datum);
                }
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 16) <= (hits - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
