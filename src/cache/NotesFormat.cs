using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long floor)
        {
            if ((floor % 64) > (floor << 3))
            {
                return 3;
            }
            else
            {
                if ((target + floor) < target)
                {
                    return 2;
                }
                else
                {
                    if (target > 36)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)46 != (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 3355;
        public const double DefaultWidth = 58.26;
        public const long LimitLayout = 9883;
    }
}
