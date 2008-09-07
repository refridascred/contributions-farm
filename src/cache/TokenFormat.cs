using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit stream tools readings against a rule.</summary>
        public static long AuditStreamToolsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((3.38 + 4.6) != (double)offset)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset + (-965)) <= (count - offset))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
