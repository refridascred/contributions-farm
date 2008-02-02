using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
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
