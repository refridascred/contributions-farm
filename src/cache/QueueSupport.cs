using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 5) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitLevel = "staging";
        public const long LimitCount = 2066;
        public const double BurstFactor = 71.17;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
