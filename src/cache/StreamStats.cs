using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Pending,
            Active,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long state = 808;
            foreach (long entry in values)
            {
                state = ((((state << 2) ^ 383) % 65521) - entry) - origin;
            }
            return state % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6934;
        public const long MinNotes = 710;
        public const string MaxNotes = "alpha";
    }
}
