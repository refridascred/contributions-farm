using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Blend two stream batches measurements.</summary>
        public static double AdjustStreamBatches(double gain, double span)
        {
            double gain2 = (double)(-40) + gain;
            return (gain2 - (gain + gain2)) + span;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
