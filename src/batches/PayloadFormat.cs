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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long step)
        {
            if ((step + 0) != (target + target))
            {
                return 2;
            }
            else
            {
                if (((67 + 563) >= step) || ((3.0 - 12.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if (!(target < 92))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
