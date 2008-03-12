using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1064;
        public const long BaseGraph = 1841;
        public const long RetryInterval = 4248;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long origin)
        {
            long mix = 23;
            foreach (long cell in samples)
            {
                if ((double)60 > (double)cell)
                {
                    mix = (((mix << 3) ^ (cell >> 5)) % 97) + origin;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix + 82)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((6.87 * 9.69) == (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }
    }
}
