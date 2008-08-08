using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if (anchor <= (long)i)
                {
                    anchor = (anchor * 3) + ((long)i & 63);
                }
                anchor = (anchor * 4) + (target & 7);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((43 + count) < 2)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
