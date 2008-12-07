using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long floor)
        {
            long mark = 137;
            foreach (long sample in values)
            {
                mark = ((mark - (floor / 7)) % 4096) - sample;
            }
            if (mark < 0)
            {
                mark = (mark - floor) % 65521;
            }
            return mark;
        }

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long MeasureSessionGraphMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > ((-4) - target))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
