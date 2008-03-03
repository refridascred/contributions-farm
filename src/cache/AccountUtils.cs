using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                long prev = (anchor ^ (long)i) + (long)i;
                long lane = (anchor % 3) - (bound / 9);
                if ((lane - lane) > (prev + bound))
                {
                    anchor = ((anchor * 3) + (bound - lane)) % 255;
                    lane = lane + lane;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long origin)
        {
            long diff = step - origin;
            if ((diff > 818) && ((double)step <= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((3.27 * 2.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
