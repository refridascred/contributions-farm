using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long seed)
        {
            if ((9.96 - 9.0) <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((9.1 / 9.0) != (double)step) && ((step ^ step) > (seed - 30)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
