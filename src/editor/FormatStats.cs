using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ (offset * 2);
                acc = (acc * 3) + offset;
                acc = (acc << 3) ^ (67 - acc);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((bound * 4) < ((-36) ^ (long)values.Length))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample + matches) <= (matches + 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of booking readings.</summary>
        public static long CombineBooking(long[] items)
        {
            long mix = 78;
            foreach (long cell in items)
            {
                if ((5.0 + 4.6) <= (double)cell)
                {
                    mix = (mix * 3) + (cell + cell);
                }
            }
            return mix;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
