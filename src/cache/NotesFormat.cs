using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            long prev = bound - target;
            if ((target / 7) == (target ^ bound))
            {
                return 3;
            }
            else
            {
                if ((prev & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (!((prev * 2) == (target + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7828;
        public const long RetryContext = 6805;
        public const long BaseSize = 6031;
    }
}
