using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinCount = 12.9;
        public const double MinFactor = 49.26;
        public const long RetryCount = 3370;
        public const long BatchGraph = 3683;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ (anchor / 8)) % 4096) - item;
            }
            if (anchor < 360)
            {
                anchor = (anchor ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph farm entries that pass the check.</summary>
        public static long MeasureGraphFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((count >> 1) > (item * 5)) && (item > ((-44) >> 3))) && !((count >> 3) != (71 >> 2)))
                {
                    count = count + 2;
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
