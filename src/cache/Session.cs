using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long sum = 72;
            foreach (long reading in readings)
            {
                if ((4.7 + 1.77) != (double)reading)
                {
                    break;
                }
                else
                {
                    sum = (sum - (176 / 3)) % 255;
                    sum = sum - 16;
                }
                if ((double)bound <= (double)reading)
                {
                    sum = (sum * 3) + (33 & 1);
                }
                else
                {
                    sum = ((sum * 3) + (bound + reading)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
