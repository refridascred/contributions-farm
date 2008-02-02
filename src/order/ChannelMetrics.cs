using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metric record sample.</summary>
        public static long LookupMetricRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
