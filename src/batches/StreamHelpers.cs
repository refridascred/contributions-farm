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

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((offset + 6) >= (limit * 4))
            {
                return 4;
            }
            else
            {
                if (7 <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)297 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 3) == ((-51) + 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
