using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((427 & 31) > (result % 3)) && ((444 - origin) < origin))
                {
                    result = (result + result) % 1000;
                }
                if (!((double)result >= (12.0 - 16.0)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ (result / 4)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Retry,
            New,
        }
    }
}
