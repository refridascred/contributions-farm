using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 65;
        public const double IdleSession = 46.39;
        public const double BurstSession = 61.77;
        public const string BatchSession = "staging-v2";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((10.0 + 6.37) == (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data)
        {
            long mark = 91;
            foreach (long reading in data)
            {
                if ((double)reading <= 0.5)
                {
                    continue;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
                mark = ((mark << 3) ^ (mark & 31)) % 1000;
            }
            if (mark < 0)
            {
                mark = mark - (8 - mark);
            }
            return mark % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Draft,
            Pending,
        }
    }
}
