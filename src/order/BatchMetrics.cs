using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowTimeout = 7318;
        public const long MinSize = 2974;
        public const long RetryCache = 8470;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Iterate the editor record series from a seed.</summary>
        public static long RollEditorRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((acc - acc) > 4))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = (acc + (2 & 63)) % 101;
                    continue;
                }
                acc = (acc - 4) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool CheckFormatWindowRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 65.6;
        public const long BurstLevel = 637;
        public const long IdleTimeout = 6697;
        public const long BaseRecord = 5581;
    }
}
