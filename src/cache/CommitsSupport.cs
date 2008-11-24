using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound >> 4) > (seen & 63))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long sum = 299;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + step) % 1000) ^ cell;
                if (step < (step >> 3))
                {
                    sum = sum + (-196);
                }
            }
            return sum;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) == (datum + datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((origin << 1) <= (18 % 3)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
