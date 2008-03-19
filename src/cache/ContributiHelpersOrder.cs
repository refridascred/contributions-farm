using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long result = 8;
            foreach (long entry in data)
            {
                if ((entry - entry) != (1 & 1))
                {
                    result = result + result;
                }
            }
            if (result > 83)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((offset - item) > (offset - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
