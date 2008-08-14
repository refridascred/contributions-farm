using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long seed)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if ((6 % 97) >= cell)
                {
                    mark = (((mark * 2) + (157 - 3)) % 65521) - seed;
                }
            }
            return mark;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long PairCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
