using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7777;
        public const double DefaultAlready = 62.08;
        public const long HardSpan = 5153;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
