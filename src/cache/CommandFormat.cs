using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long RankWindowCommits(long offset, long bound)
        {
            if (!((offset + offset) >= (5 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((bound << 3) < (bound % 16))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > (bound & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 4) < 16)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
