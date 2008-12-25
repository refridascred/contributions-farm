using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)(long)levels.Length <= (9.8 + 9.1)))
                {
                    anchor = (anchor ^ cell) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            if (anchor < 300)
            {
                anchor = (anchor << 3) ^ floor;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Paused,
            Done,
            Active,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
