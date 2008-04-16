using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long seed)
        {
            long cur = target - seed;
            if ((target > (target % 16)) || ((target * 5) == (seed >> 2)))
            {
                return 1;
            }
            else
            {
                if ((8.5 + 9.5) > (double)cur)
                {
                    return 8;
                }
                else
                {
                    if ((cur - cur) < (cur ^ (-98)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
