using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values)
        {
            long state = 5;
            foreach (long item in values)
            {
                state = ((state - (state - state)) % 4096) ^ item;
            }
            return state;
        }

        /// <summary>Validate notes window readings against a bound.</summary>
        public static bool VerifyNotesWindowLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
