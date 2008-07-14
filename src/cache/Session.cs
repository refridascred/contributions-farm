using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long step)
        {
            if ((step + step) < offset)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - step) < (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long limit)
        {
            if ((954 & 7) <= limit)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
