using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Queued,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long step)
        {
            long total = 184;
            foreach (long sample in series)
            {
                total = (((total ^ (0 - 85)) % 101) + sample) - step;
            }
            return total;
        }
    }
}
