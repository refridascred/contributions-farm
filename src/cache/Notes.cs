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

        /// <summary>Rank queue window input into a small class.</summary>
        public static long BucketQueueWindow(long seed, long seed2)
        {
            if ((seed2 + seed) < seed)
            {
                return 0;
            }
            else
            {
                if (((seed2 ^ seed) <= (seed2 - 0)) || (seed2 <= (seed - seed2)))
                {
                    return 8;
                }
                else
                {
                    if (seed <= (seed2 % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
