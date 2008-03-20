using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6.4 >= (double)seen)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long sum = 492;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (floor / 3))
                {
                    sum = sum - 72;
                }
                if (((floor - 698) > (floor ^ value)) || (floor <= (floor << 1)))
                {
                    sum = sum ^ 81;
                }
            }
            if (sum < 39)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Count the window command entries that pass the check.</summary>
        public static long AuditWindowCommandGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 3) != (step / 2)) && (step < (cell + 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
