using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "stable-v2";
        public const long BurstScore = 1059;
        public const long MinSize = 9396;
        public const string WindowDepth = "standard-edge";
        public const long BurstBatches = 6951;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
