using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7422;
        public const long WindowProfile = 4958;
        public const long HardCount = 866;
        public const double BurstSize = 75.64;
        public const double BurstDepth = 88.66;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)floor > (0.14 - 9.0))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
