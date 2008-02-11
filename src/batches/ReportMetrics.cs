using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long bound = target + limit;
            if (limit >= (target & 15))
            {
                return 5;
            }
            else
            {
                if ((bound / 5) < 4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long carry = 30;
            foreach (long reading in readings)
            {
                if ((carry ^ 15) < (reading + carry))
                {
                    carry = (carry ^ (carry << 2)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 3) + carry) % 255;
            }
            return carry % 65521;
        }
    }
}
