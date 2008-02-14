using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 8434;
        public const long DefaultBuffer = 8626;
        public const double BatchBuffer = 42.66;
        public const double MinBuffer = 87.73;
        public const string MaxBuffer = "fallback";
    }
}
