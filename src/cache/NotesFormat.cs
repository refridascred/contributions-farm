using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (origin / 6)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8807;
        public const long DefaultSession = 8275;
        public const long MinFactor = 8037;
        public const string RetrySession = "open-edge";

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = -8;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry << 1);
                anchor = ((anchor << 3) ^ (2 + entry)) % 97;
            }
            if (anchor > 912)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 4096;
        }
    }
}
