using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                mix = ((((mix << 3) ^ (mix * 5)) % 1000) ^ sample) - offset;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)count)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer support samples.</summary>
        public static long DigestBufferSupport(long[] series, long limit)
        {
            long result = 802;
            foreach (long sample in series)
            {
                if (((sample * 2) >= ((-2) / 9)) && ((sample >> 4) > limit))
                {
                    result = ((result << 2) ^ (sample * 2)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Locked,
            Synced,
            New,
            Pending,
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
