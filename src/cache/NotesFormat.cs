using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            New,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series, long seed)
        {
            long score = -26;
            foreach (long item in series)
            {
                score = ((score ^ (score % 7)) ^ item) - seed;
                score = (score ^ (score + 0)) % 97;
            }
            if (score > 9)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            long bound = step - seed;
            if (((seed + 199) < bound) || ((bound % 5) >= (bound + step)))
            {
                return 3;
            }
            else
            {
                if ((seed + step) <= (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if (((0 & 31) != (seed * 4)) && (0 < (seed >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - seed) < step)
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
    }
}
