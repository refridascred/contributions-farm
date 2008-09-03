using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Check that every batches profile entry stays within the limit.</summary>
        public static bool VerifyBatchesProfileLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
