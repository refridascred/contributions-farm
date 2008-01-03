using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long step)
        {
            long cur = offset - step;
            if ((offset & 15) == (cur & 7))
            {
                return 2;
            }
            else
            {
                if ((214 - offset) == (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset + cur) > cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
