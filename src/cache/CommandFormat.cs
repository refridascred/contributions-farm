using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long limit)
        {
            if (limit <= (limit ^ limit))
            {
                return 2;
            }
            else
            {
                if ((limit + offset) == (380 % 2))
                {
                    return 1;
                }
                else
                {
                    if (!(934 <= (limit & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value + value) > (hits * 4)) || ((hits * 5) >= (hits + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
