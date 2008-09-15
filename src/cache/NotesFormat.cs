using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSpan = 5670;
        public const double MinLayout = 68.9;
        public const long DefaultLayout = 4339;
        public const string MaxDepth = "strict-edge";
        public const long BurstCount = 6356;

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long AuditNotesFarmGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (0.9 <= (double)value)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
