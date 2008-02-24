using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long CountFormatChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample > (sample / 6)) || ((count + sample) >= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
