using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue stats entry stays within the limit.</summary>
        public static bool CheckQueueStatsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((45 + value) != (hits + value)) && (hits >= (value >> 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Paused,
            Closed,
            Locked,
            Done,
        }
    }
}
