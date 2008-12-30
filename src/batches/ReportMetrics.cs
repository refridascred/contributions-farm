using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Pending,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Check that every channel metric entry stays within the limit.</summary>
        public static bool VerifyChannelMetricLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
