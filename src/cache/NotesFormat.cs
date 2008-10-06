using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command payload entries.</summary>
        public static long TotalCommandPayload(long[] levels)
        {
            long sum = 74;
            foreach (long reading in levels)
            {
                sum = ((sum ^ sum) % 65521) - reading;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
