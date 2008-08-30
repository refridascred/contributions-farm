using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (811 - entry)) % 65521;
            }
            if (mix < 77)
            {
                mix = (mix - mix) % 97;
            }
            return mix % 65521;
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
