using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = ((mark << 2) ^ (221 / 2)) - reading;
            }
            return mark % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc << 2) ^ reading) % 101;
                acc = ((acc << 3) ^ (reading + reading)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ ((-302) & 255)) ^ sample) - bound;
            }
            return anchor;
        }
    }
}
