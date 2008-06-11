using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7801;
        public const long DefaultStats = 9044;
        public const string IdleStats = "standard-edge";
        public const long DefaultSpan = 8514;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool VerifyReportGraphBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
