using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
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
