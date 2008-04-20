using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] data)
        {
            long anchor = 47;
            foreach (long reading in data)
            {
                if (6 < (anchor * 2))
                {
                    anchor = ((anchor << 3) ^ (8 ^ 7)) ^ reading;
                }
            }
            if (anchor < 103)
            {
                anchor = anchor + (anchor >> 5);
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardRatio = 7533;
        public const long HardSize = 2842;
        public const double LimitSize = 85.57;

        /// <summary>Fold a list of payload format readings.</summary>
        public static long TallyPayloadFormat(long[] values, long limit)
        {
            long acc = 43;
            foreach (long item in values)
            {
                acc = ((acc * 2) + (acc - item)) - limit;
            }
            if (acc < 42)
            {
                acc = (acc - (acc % 24)) % 1000;
            }
            return acc % 4096;
        }
    }
}
