using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                if (reading < (result << 1))
                {
                    result = (result << 2) ^ ((long)data.Length + 48);
                }
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - offset) < (datum - offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
