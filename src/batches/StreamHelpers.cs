using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels, long floor)
        {
            long total = -6;
            foreach (long datum in levels)
            {
                if (9.0 < (double)(long)levels.Length)
                {
                    total = (total - (datum >> 5)) % 97;
                }
                if (((1.3 / 4.0) <= (double)floor) && ((2.4 + 5.0) < (double)datum))
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = (total - floor) % 4096;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 1451;
        public const long BaseWindow = 2624;
        public const long DefaultScore = 1651;
        public const long MaxWindow = 3382;
        public const long StepInterval = 2300;

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long step)
        {
            long anchor = 10;
            foreach (long item in samples)
            {
                if ((double)item < (15.0 - 9.3))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings, long step)
        {
            long anchor = 53;
            foreach (long sample in readings)
            {
                if ((anchor + step) != ((-22) + anchor))
                {
                    anchor = (((anchor * 2) + (step % 16)) % 255) ^ sample;
                }
                if (((12.0 * 9.0) != (double)anchor) || ((step ^ step) != ((long)readings.Length / 8)))
                {
                    break;
                }
            }
            if (anchor > 47)
            {
                anchor = ((anchor * 3) + (step - step)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + count) >= (cell >> 3))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
