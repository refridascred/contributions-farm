using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the editor buffer entries that pass the check.</summary>
        public static long MeasureEditorBufferHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((step + 6) > (823 >> 5)) && ((((long)data.Length & 63) <= reading) && ((124 % 12) <= (hits - reading))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) != (count + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
