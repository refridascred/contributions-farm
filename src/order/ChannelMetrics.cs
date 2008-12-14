using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 2) <= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
