using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry + entry) >= (entry / 7)) && ((6.0 + 4.9) >= (double)entry)) && ((4.0 / 9.0) < (double)matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels, long seed)
        {
            long mark = -28;
            foreach (long reading in levels)
            {
                mark = ((mark + (seed * 5)) % 97) + reading;
            }
            return mark;
        }
    }
}
