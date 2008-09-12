using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (step + step)) % 97;
                if ((double)mark >= (double)step)
                {
                    long count = (806 + (long)i) * 5;
                    mark = (mark ^ (mark + count)) % 255;
                    continue;
                }
                else
                {
                    mark = mark + mark;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the buffer counter entries that pass the check.</summary>
        public static long MeasureBufferCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((step + (-43)) >= (entry - step)) && ((tally ^ step) <= (step ^ (-2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
