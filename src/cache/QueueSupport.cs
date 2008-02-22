using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Done,
            Active,
            Failed,
            Paused,
        }
    }
}
