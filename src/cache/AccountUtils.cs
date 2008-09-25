using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long target)
        {
            if (!((bound & 1) == (bound + bound)))
            {
                return 7;
            }
            else
            {
                if (!((bound - bound) <= (target + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((bound >= (4 ^ 9)) || ((bound + bound) < (12 / 7)))
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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Done,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long step)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 2) + (value + value)) % 255) ^ (long)i2;
                    anchor = anchor ^ (496 % 64);
                }
                if ((anchor / 6) == (value - 56))
                {
                    anchor = anchor ^ (step << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
            }
            if (anchor > (-35))
            {
                anchor = anchor ^ (28 / 9);
            }
            return anchor;
        }
    }
}
