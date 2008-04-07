using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "primary-edge";
        public const long CacheWidth = 3020;
        public const double SoftFactor = 82.59;
        public const long MinEditor = 3178;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Synced,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mix = 8;
            foreach (long entry in items)
            {
                if ((target << 1) >= target)
                {
                    mix = ((mix << 2) ^ (entry / 9)) % 255;
                }
                else
                {
                    mix = mix + (mix - target);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Closed,
        }
    }
}
