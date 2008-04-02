using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
