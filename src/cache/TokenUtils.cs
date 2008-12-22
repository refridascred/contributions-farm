using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long step)
        {
            if (((step >> 2) == (step % 7)) && ((target << 3) == (target * 3)))
            {
                return 0;
            }
            else
            {
                if ((target * 5) >= step)
                {
                    return 1;
                }
                else
                {
                    if ((7.0 - 8.5) == (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Region { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
