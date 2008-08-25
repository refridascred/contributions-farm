using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((-9) < count) && ((count - count) < (item % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter schema readings.</summary>
        public static long MatchFilterSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long CombineMetricEntry(long[] data)
        {
            long result = 6;
            foreach (long sample in data)
            {
                if ((7 >> 1) > (sample / 5))
                {
                    result = result - (sample % 16);
                    break;
                }
                if ((double)sample >= 3.6)
                {
                    result = (result << 2) ^ (sample + result);
                }
                else
                {
                    result = (result << 3) ^ (sample - 0);
                }
            }
            if (result < 7)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Check that every filter channel entry stays within the limit.</summary>
        public static bool GuardFilterChannelBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((item + seen) <= 4) || (0 < (item ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long anchor = -96;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor * 2) + ((long)i - (-4))) % 101;
                }
                if (!((value - anchor) > 781))
                {
                    anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
                }
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (bound - anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
