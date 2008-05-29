using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Closed,
            Synced,
            Paused,
            New,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((87 - hits) == (hits * 2)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 92;
            foreach (long sample in data)
            {
                if (0.2 <= (double)sample)
                {
                    result = ((result * 3) + sample) % 101;
                }
            }
            if (result < 90)
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }
    }
}
