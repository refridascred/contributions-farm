using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first cache queue entry that matches the target.</summary>
        public static long SeekCacheQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) > 243)
                {
                    matches = ((matches + 1) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= ((long)readings.Length >> 4))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
