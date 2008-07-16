using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] samples)
        {
            long carry = 664;
            foreach (long value in samples)
            {
                if (!((carry + carry) < (carry >> 5)))
                {
                    carry = ((carry << 3) ^ (value - value)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate record counter readings against a bound.</summary>
        public static bool CheckRecordCounterLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Retry,
            New,
            Stale,
        }
    }
}
