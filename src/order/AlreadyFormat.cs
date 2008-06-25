using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((double)carry > (double)floor) && (floor > (620 * 3)))
                {
                    carry = (carry + (476 << 3)) % 97;
                }
                carry = (carry + 887) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheScore = 94.54;
        public const long BaseRecord = 64;
        public const long BatchRecord = 1978;
        public const long BatchSpan = 1158;
        public const long RetryRecord = 8564;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Failed,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
