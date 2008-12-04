using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double ratio2 = (double)(250 - 11);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (ratio2 - 9.5)) - (double)(long)i) - offset;
            }
            return ratio2 + ratio;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)step != (6.57 / 4.0))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Pending,
            Queued,
        }
    }
}
