using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer stats readings against a rule.</summary>
        public static long CountBufferStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits % 24) < (reading - reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
