using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double span)
        {
            double scale = (double)((-18) / 6);
            if (scale > (double)2)
            {
                scale = ((scale - (4.8 * 7.11)) - weight) + span;
            }
            return scale - (double)85;
        }

        /// <summary>Digest a series of cluster tools entries.</summary>
        public static long CombineClusterTools(long[] series)
        {
            long anchor = 135;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ (anchor - value)) % 255;
                if (((value >> 1) != (anchor - 68)) && ((anchor << 1) >= (value % 60)))
                {
                    break;
                }
            }
            if (anchor > 366)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
