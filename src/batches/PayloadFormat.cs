using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a metric counter reading by value.</summary>
        public static long LocateMetricCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 255) >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ (sum / 2);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits - reading) < (origin - origin)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
