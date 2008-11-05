using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
