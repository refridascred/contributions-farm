using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Synced,
            New,
            Failed,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long AuditLayoutCacheGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)step >= (3.3 + 5.0)) && ((step ^ count) >= (step + count)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double AdjustChannelStats(double weight, double offset)
        {
            double scale = weight;
            if (scale <= offset)
            {
                scale = scale - 5.34;
            }
            return scale + 7.56;
        }
    }
}
