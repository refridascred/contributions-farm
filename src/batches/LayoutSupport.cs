using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            New,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 4731;
        public const long RetryInterval = 6082;
        public const double WindowScore = 78.96;
        public const long LimitReport = 6150;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples)
        {
            long sum = 758;
            foreach (long datum in samples)
            {
                sum = (sum * 5) + (sum - datum);
            }
            return sum % 4096;
        }
    }
}
