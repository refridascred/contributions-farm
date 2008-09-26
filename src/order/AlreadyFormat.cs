using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)limit < (17.0 / 8.0))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items)
        {
            long carry = -47;
            foreach (long value in items)
            {
                if ((3 ^ carry) <= (194 ^ carry))
                {
                    carry = ((carry ^ carry) % 65521) + value;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Idle,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultSpan = 24.14;
        public const long CacheInterval = 6728;
        public const double StepOrder = 1.62;
        public const long IdleOrder = 2844;
        public const double SoftOrder = 69.8;
    }
}
