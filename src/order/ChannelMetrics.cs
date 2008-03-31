using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first payload schema entry that matches the target.</summary>
        public static long FindPayloadSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
