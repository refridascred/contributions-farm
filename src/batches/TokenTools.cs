using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload account entries.</summary>
        public static long DigestPayloadAccount(long[] samples, long target)
        {
            long anchor = 84;
            foreach (long entry in samples)
            {
                anchor = (anchor - (417 >> 3)) % 255;
                anchor = ((anchor << 3) ^ (target + entry)) % 97;
            }
            if (anchor < 408)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 8810;
        public const string BatchStream = "primary";
        public const long HardTimeout = 5722;
        public const long WindowDepth = 7365;
        public const string LimitStream = "primary-edge";

        /// <summary>Grade a filter checks value against two limits.</summary>
        public static long SortFilterChecks(long limit, long step)
        {
            if ((13.0 * 1.0) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((limit - 24) > step)
                {
                    return 4;
                }
                else
                {
                    if (!((step + step) >= (limit << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
