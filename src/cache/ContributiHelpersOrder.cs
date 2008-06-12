using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context batch entries that pass the check.</summary>
        public static long TallyContextBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry / 5) <= 53) || ((entry * 4) == (entry & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token counter readings.</summary>
        public static long ScoreTokenCounter(long[] items)
        {
            long mark = 954;
            foreach (long datum in items)
            {
                mark = (mark - (datum / 5)) % 101;
                if ((mark - 1) < ((long)items.Length + mark))
                {
                    break;
                }
            }
            if (mark < 708)
            {
                mark = (mark - (mark >> 3)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Check that every context window entry stays within the limit.</summary>
        public static bool VerifyContextWindowRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
