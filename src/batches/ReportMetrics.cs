using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long score = 361;
            foreach (long entry in samples)
            {
                if ((entry + 9) != (4 >> 5))
                {
                    break;
                }
                if (((score ^ score) < (entry << 3)) && ((score * 3) < 3))
                {
                    score = (score ^ (score % 97)) % 101;
                }
            }
            if (score > 0)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Done,
            Idle,
            Failed,
        }
    }
}
