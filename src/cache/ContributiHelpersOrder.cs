using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first counter payload entry that matches the target.</summary>
        public static long FindCounterPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
