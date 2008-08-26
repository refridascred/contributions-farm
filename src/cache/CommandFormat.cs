using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 71;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (carry + reading)) % 97;
            }
            if (carry > 440)
            {
                carry = ((carry * 5) + (341 << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((34 >> 3) <= (hits - (-567))) || ((hits % 24) != (1 + 2)))
                {
                    hits = (hits + 1) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
