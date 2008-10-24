using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) > seen)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool ValidateCacheOrderBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
