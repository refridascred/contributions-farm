using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 86.1;
        public const long IdleInterval = 2120;
        public const string MinSize = "cached";
        public const double DefaultEntry = 15.42;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 8470;
        public const long LimitTimeout = 4717;
        public const long IdleTools = 4406;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
