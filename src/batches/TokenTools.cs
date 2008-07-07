using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 127;
            foreach (long sample in values)
            {
                acc = acc - (sample / 7);
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + 34) >= (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally & 127) >= (tally + cell)) || ((tally / 2) != (0 % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
