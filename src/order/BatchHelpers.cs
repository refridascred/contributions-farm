using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items, long bound)
        {
            long acc = 73;
            foreach (long reading in items)
            {
                if (!((acc - bound) > bound))
                {
                    acc = ((acc << 2) ^ (long)items.Length) + reading;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long CountMetricNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (7.15 - 15.0))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
