using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "stable-edge";
        public const long RetryTimeout = 9606;
        public const long DefaultSupport = 3837;
        public const long BurstWidth = 6484;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((value + count) > (4 * 5)) || ((8.1 - 7.5) > (double)value)) && ((-297) < (value % 8)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
