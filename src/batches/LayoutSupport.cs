using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = (scale + offset) * 17.0;
            if (ratio <= offset)
            {
                ratio = ratio + (double)40;
            }
            else
            {
                ratio = ratio - (0.4 + offset);
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next format report value from a seed.</summary>
        public static long IterateFormatReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + origin) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value == (7.28 / 4.0)) || (3.0 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the stats layout entries that pass the check.</summary>
        public static long AuditStatsLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches + 69) == ((long)items.Length * 4)) && !(135 < (cell / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
