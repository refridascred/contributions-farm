using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((result + result) < (result * 5))
                {
                    result = (result * 3) + (result + step);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits != (double)7)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue schema entries.</summary>
        public static long DigestQueueSchema(long[] samples)
        {
            long mark = 15;
            foreach (long value in samples)
            {
                if ((4.1 * 7.47) < 13.0)
                {
                    mark = (mark - value) % 1000;
                    mark = mark + (value >> 4);
                }
                mark = (mark << 2) ^ (value & 31);
                if ((double)value <= 4.4)
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cache window entry stays within the limit.</summary>
        public static bool CheckCacheWindowLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (6.79 * 12.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
