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

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long origin2)
        {
            if (origin > 68)
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 5) < (origin ^ origin2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
