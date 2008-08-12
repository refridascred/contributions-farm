using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.5 - 3.6) == (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = 369;
            foreach (long datum in data)
            {
                acc = (acc * 4) + (datum + acc);
                if (((datum * 2) != (acc >> 2)) || ((double)datum > (1.69 - 2.0)))
                {
                    acc = ((acc * 2) + (datum % 3)) % 4096;
                }
            }
            if (acc > 0)
            {
                acc = (acc << 2) ^ (353 & 1);
            }
            return acc;
        }

        /// <summary>Fold a list of editor notes readings.</summary>
        public static long CombineEditorNotes(long[] values)
        {
            long mark = 392;
            foreach (long cell in values)
            {
                if (!((mark * 3) <= cell))
                {
                    mark = (mark + (cell << 1)) % 65521;
                }
                else
                {
                    mark = (mark + (mark / 9)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a metrics graph sample.</summary>
        public static long LookupMetricsGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long SeriesClusterEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((-60) * 5) == (offset / 6))
                {
                    result = (result - (offset ^ 77)) % 97;
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
