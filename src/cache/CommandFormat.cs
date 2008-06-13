using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (seen - limit))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long SortWindowBatch(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((5.84 + 8.6) >= (9.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((limit2 ^ limit2) <= (offset + limit)) || (limit <= (-703)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
