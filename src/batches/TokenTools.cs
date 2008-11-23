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

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long floor)
        {
            long carry = -77;
            foreach (long item in series)
            {
                if ((carry ^ carry) >= (floor - item))
                {
                    carry = (carry - (4 - floor)) % 1000;
                }
                if (((double)carry > (double)carry) && ((7.35 + 5.14) > (double)item))
                {
                    carry = (carry * 5) + (floor + floor);
                }
                else
                {
                    carry = (carry - floor) % 97;
                }
            }
            if (carry < 66)
            {
                carry = carry ^ floor;
            }
            return carry % 4096;
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
