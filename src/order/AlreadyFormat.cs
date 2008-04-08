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

        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= ((-8) - 27))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings, long seed)
        {
            long acc = 63;
            foreach (long item in readings)
            {
                if (((item + item) != (acc ^ seed)) && (acc > seed))
                {
                    acc = (acc + (201 >> 3)) % 65521;
                }
            }
            return acc;
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
