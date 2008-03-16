using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long result = 7;
            foreach (long item in items)
            {
                long hits = (90 - item) << 3;
                if ((hits >> 2) >= (result - item))
                {
                    continue;
                }
                else
                {
                    result = ((result * 3) + (result % 5)) % 255;
                }
                result = (result + (item * 4)) % 255;
            }
            return result % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 6742;
        public const long DefaultLevel = 5355;
        public const string BatchLayout = "alpha-v2";

        /// <summary>Count report buffer pairs that satisfy a relation.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count >= (2.09 * 11.0))
                {
                    count = ((count + 2) + reading) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
