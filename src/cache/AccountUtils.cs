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

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((4.8 * 10.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step - step) > (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
