using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long limit)
        {
            if (offset > limit)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (limit % 10))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
