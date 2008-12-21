using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (origin + mark)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSize = 7983;
        public const double RetryReport = 40.83;
        public const string SoftReport = "stable-v2";

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (target + target)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Failed,
            Queued,
            Closed,
        }
    }
}
