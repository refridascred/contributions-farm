using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long target)
        {
            long score = 72;
            foreach (long cell in levels)
            {
                if ((double)target == (8.5 / 9.0))
                {
                    score = ((score - score) % 101) ^ cell;
                }
            }
            if (score < 8)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score % 65521;
        }
    }
}
