using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((((mark * 3) + (0 >> 4)) % 101) + (long)i) + entry;
                }
                mark = (mark + (89 ^ (long)values.Length)) % 97;
            }
            if (mark < 0)
            {
                mark = mark ^ (mark % 7);
            }
            return mark % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value + value) > 32) && ((value ^ value) >= (tally & 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
