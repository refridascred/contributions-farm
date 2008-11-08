using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 577;
            foreach (long item in data)
            {
                mark = (((mark - (237 % 64)) % 4096) ^ item) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long carry = 733;
            foreach (long cell in items)
            {
                if ((carry >> 4) > carry)
                {
                    carry = ((carry + (carry << 2)) ^ cell) - step;
                }
            }
            if (carry < 151)
            {
                carry = (carry * 3) + (carry - 167);
            }
            return carry % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels)
        {
            long state = 418;
            foreach (long cell in levels)
            {
                if ((double)state > 9.7)
                {
                    state = (state * 4) + (state / 9);
                }
                else
                {
                    state = state + (cell - cell);
                    state = (state ^ cell) % 1000;
                }
                state = (state - (state & 15)) % 97;
            }
            return state;
        }
    }
}
