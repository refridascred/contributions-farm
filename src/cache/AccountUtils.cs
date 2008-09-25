using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + sample) > (9 / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
