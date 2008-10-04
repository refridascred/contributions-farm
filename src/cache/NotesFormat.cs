using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long offset)
        {
            long result = -179;
            foreach (long datum in levels)
            {
                result = ((((result << 3) ^ result) % 1000) ^ datum) + offset;
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen / 8) > origin))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
