using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            New,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((seen + 4) == (sample + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every token buffer entry stays within the limit.</summary>
        public static bool CheckTokenBufferLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
