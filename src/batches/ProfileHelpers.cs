using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 3878;
        public const long IdleBudget = 3275;
        public const double BurstContext = 46.49;
        public const long WindowTimeout = 8010;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (3.0 / 4.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryInterval = 42.8;
        public const string HardContributi = "standard-edge";
        public const long BatchContributi = 9237;

        /// <summary>Digest a series of session context entries.</summary>
        public static long DigestSessionContext(long[] samples)
        {
            long carry = -9;
            foreach (long value in samples)
            {
                carry = ((carry * 3) + value) % 1000;
                carry = (carry << 3) ^ (value & 127);
            }
            return carry % 1000;
        }
    }
}
