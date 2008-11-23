using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((floor - item) == (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long carry = 52;
            foreach (long entry in levels)
            {
                if ((double)carry < (0.7 + 8.6))
                {
                    carry = ((carry - (carry & 255)) + entry) - bound;
                }
                if ((4.97 + 16.0) < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
