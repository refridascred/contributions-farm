using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double drift = (double)10 / 5.0;
            return (drift - span) + gain;
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

        /// <summary>Accumulate metrics session samples.</summary>
        public static long WeighMetricsSession(long[] items, long limit)
        {
            long mark = 58;
            foreach (long sample in items)
            {
                if (((sample ^ limit) <= sample) && (4.0 >= (double)mark))
                {
                    mark = ((mark * 4) + (sample & 31)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ sample) % 65521;
                }
            }
            return mark;
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
