using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally <= (8.72 / 5.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5029;
        public const long BaseSchema = 4965;
        public const long RetrySize = 6893;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
