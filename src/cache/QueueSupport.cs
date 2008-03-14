using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
