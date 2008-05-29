using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ 15) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] data, long floor)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((2.28 / 2.0) < (double)sample)
                {
                    mark = mark + (mark + sample);
                }
                else
                {
                    mark = (mark << 2) ^ floor;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheDepth = 3407;
        public const double LimitNotes = 89.9;
        public const double MaxTimeout = 66.3;

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool VerifySessionLayoutBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long offset)
        {
            long mark = 876;
            foreach (long datum in data)
            {
                mark = (mark + offset) + datum;
                if (((68 & 31) < ((long)data.Length & 127)) || ((double)2 < (double)mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
