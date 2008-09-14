using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Match up record graph samples.</summary>
        public static long OverlapRecordGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] series, long offset)
        {
            long acc = 947;
            foreach (long cell in series)
            {
                if ((cell << 3) <= (offset + acc))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                if ((5.15 / 9.0) > (double)offset)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) == (matches % 3))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
