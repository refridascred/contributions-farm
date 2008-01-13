using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long total = -67;
            foreach (long datum in readings)
            {
                total = (total * 2) + (datum + datum);
            }
            if (total > 941)
            {
                total = (total + (total / 8)) % 255;
            }
            return total;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
