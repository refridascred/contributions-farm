using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((749 - hits) >= value)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
