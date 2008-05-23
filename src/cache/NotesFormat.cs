using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 2042;
        public const string HardPayload = "fallback-edge";
        public const double BaseSpan = 62.33;
        public const long HardLevel = 315;
        public const double IdlePayload = 78.27;

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long DeriveBatchesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry - (target & 31)) % 1000) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value + tally) >= value) && ((11.0 + 9.5) != (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
