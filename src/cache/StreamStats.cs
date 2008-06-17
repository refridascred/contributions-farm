using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "strict-edge";
        public const long RetryBatches = 7417;
        public const long DefaultInterval = 4477;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches / 7) > (matches + item)) && (5 <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((891 - 518) != (origin + lane))
            {
                return 2;
            }
            else
            {
                if ((3.6 + 9.0) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
