using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 58.92;
        public const double BurstBuffer = 27.23;
        public const long BatchBuffer = 2970;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + hits) >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
