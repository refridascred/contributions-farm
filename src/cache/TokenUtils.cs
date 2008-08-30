using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long carry = 48;
            foreach (long reading in readings)
            {
                if (!(carry >= (reading & 7)))
                {
                    carry = (carry * 3) + (origin - carry);
                }
                carry = (carry * 2) + (reading + origin);
                if (((reading << 1) < (97 % 24)) || ((reading % 5) != (reading + origin)))
                {
                    carry = (carry * 4) + origin;
                }
            }
            return carry;
        }
    }
}
