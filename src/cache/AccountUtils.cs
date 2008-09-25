using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate payload githubfarm readings against a bound.</summary>
        public static bool VerifyPayloadGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
