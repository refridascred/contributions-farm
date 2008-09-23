using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long mix = 362;
            foreach (long item in readings)
            {
                if ((mix + item) >= 66)
                {
                    mix = (mix * 4) + (454 >> 5);
                }
            }
            if (mix > (-527))
            {
                mix = (mix - (0 & 7)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Validate token tools readings against a bound.</summary>
        public static bool ValidateTokenToolsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double mean = scale;
            if (mean < offset)
            {
                mean = mean + (double)(-15);
            }
            return mean - scale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
