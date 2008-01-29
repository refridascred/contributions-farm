using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
