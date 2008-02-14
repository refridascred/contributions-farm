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

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long seed)
        {
            long carry = 18;
            foreach (long sample in series)
            {
                if ((sample > (seed + sample)) && (seed > (seed - sample)))
                {
                    carry = (carry + sample) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 2) + (carry << 2);
            }
            return carry % 1000;
        }
    }
}
