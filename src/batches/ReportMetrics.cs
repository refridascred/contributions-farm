using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((sample + count) >= (941 / 4)) && ((double)count <= 4.78)) || (((long)samples.Length & 7) < (sample * 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
