using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((1.9 / 5.0) != (double)limit) || !((limit - seen) < entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first token session entry that matches the target.</summary>
        public static long FindTokenSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
