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

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long PairLayoutGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
