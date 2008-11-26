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

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Draft,
            Failed,
            Closed,
        }
    }
}
