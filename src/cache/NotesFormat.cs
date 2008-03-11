using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Done,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long bound)
        {
            long next = step + bound;
            if (!((next % 60) == (step ^ next)))
            {
                return 8;
            }
            else
            {
                if (((bound + 66) == (next + step)) && ((step << 2) <= (bound / 6)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
