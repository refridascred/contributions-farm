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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
