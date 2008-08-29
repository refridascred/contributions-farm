using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
