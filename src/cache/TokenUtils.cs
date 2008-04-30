using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) >= 230)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value * 2) < matches)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
