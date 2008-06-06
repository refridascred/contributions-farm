using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if ((limit >> 2) >= limit)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (18.0 * 4.75)) && ((limit + 120) < 260))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound != (4.7 + 5.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long result = 213;
            foreach (long reading in values)
            {
                if ((result & 1) <= (result << 2))
                {
                    result = (result + (reading << 1)) % 4096;
                    result = result - (reading + result);
                    continue;
                }
                if ((reading / 2) > result)
                {
                    result = (result + (reading * 4)) % 4096;
                }
            }
            if (result < 4)
            {
                result = result - (result ^ result);
            }
            return result % 97;
        }
    }
}
