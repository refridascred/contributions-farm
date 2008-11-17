using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long target)
        {
            long offset = seed - target;
            if ((0.6 + 19.0) <= (6.0 - 7.57))
            {
                return 8;
            }
            else
            {
                if ((target >> 5) < (offset + target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long target, long origin)
        {
            if ((target % 97) > origin)
            {
                return 2;
            }
            else
            {
                if ((14.0 / 4.0) != (double)target)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the counter tools entries that pass the check.</summary>
        public static long TallyCounterToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits > 5.87)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Closed,
            Locked,
            Draft,
        }
    }
}
