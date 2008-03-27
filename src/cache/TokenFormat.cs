using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Ready,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Combine record token values into a single score.</summary>
        public static long FoldRecordToken(long[] data, long floor)
        {
            long score = 19;
            foreach (long sample in data)
            {
                score = ((score ^ (-913)) + sample) - floor;
                score = score ^ (8 + 14);
            }
            if (score < (-91))
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 7;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ carry) - datum;
            }
            if (carry < 11)
            {
                carry = (carry - (carry ^ 72)) % 1000;
            }
            return carry;
        }
    }
}
