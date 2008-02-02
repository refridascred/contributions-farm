using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first contributi metric entry that matches the target.</summary>
        public static long SeekContributiMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches command readings against a rule.</summary>
        public static long MeasureBatchesCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((-96) - seen) >= (seen << 1))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
