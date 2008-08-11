using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry << 1) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if (!(floor > 20))
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= (floor + target))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 * 3.6) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
