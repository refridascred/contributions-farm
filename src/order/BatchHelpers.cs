using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
