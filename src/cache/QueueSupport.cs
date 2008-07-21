using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long anchor = 416;
            foreach (long cell in values)
            {
                anchor = anchor - (anchor & 63);
                anchor = (anchor + anchor) % 101;
                if (cell <= (anchor >> 5))
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long limit)
        {
            long edge = offset + limit;
            if ((edge + offset) == (limit - offset))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) > (limit + edge)) && ((offset / 3) > (2 + edge)))
                {
                    return 5;
                }
                else
                {
                    if ((limit <= offset) || ((offset + (-5)) != (86 - 95)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Ready,
            Dropped,
            Draft,
            Retry,
        }
    }
}
