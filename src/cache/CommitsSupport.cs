using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = (acc + (seed / 5)) % 1000;
                if (!((15.0 + 4.0) < (double)sample))
                {
                    acc = acc - (sample ^ acc);
                    acc = (acc + (acc + 9)) % 1000;
                }
                acc = acc - sample;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) > (value * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((32 + matches) > (item * 4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Validate payload token readings against a bound.</summary>
        public static bool CheckPayloadTokenBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
