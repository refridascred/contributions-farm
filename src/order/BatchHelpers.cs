using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((long)i < (7 * 2)))
                {
                    mark = (mark - (mark - (long)i)) % 4096;
                    mark = (mark << 3) ^ (mark & 255);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
