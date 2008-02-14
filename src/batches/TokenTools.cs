using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample >= (sample & 3)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long seed)
        {
            long score = 9;
            foreach (long item in items)
            {
                if (((score >> 1) >= (score % 12)) && (item <= (item + 70)))
                {
                    score = ((score << 3) ^ (seed * 3)) % 4096;
                    score = score ^ (39 & 255);
                }
                score = score ^ (item * 5);
            }
            if (score < 318)
            {
                score = score - (seed >> 4);
            }
            return score;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
