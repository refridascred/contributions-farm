using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Done,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Idle,
            Ready,
            Failed,
        }
    }
}
