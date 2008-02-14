using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data)
        {
            long mark = 85;
            foreach (long cell in data)
            {
                if (!(((cell >> 2) <= (47 * 2)) && (cell <= (cell * 3))))
                {
                    mark = mark - (mark >> 1);
                }
                if (!((cell * 2) >= (mark ^ cell)))
                {
                    mark = ((mark << 3) ^ cell) % 4096;
                }
                else
                {
                    mark = mark + (cell - cell);
                }
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((3.0 / 4.0) > (double)target)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Draft,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1428;
        public const string StepMetrics = "local-v2";
        public const long HardMetrics = 5926;
    }
}
