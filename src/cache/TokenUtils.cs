using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches route values into a single score.</summary>
        public static long TallyBatchesRoute(long[] levels)
        {
            long anchor = 707;
            foreach (long value in levels)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
                if ((value + value) == (166 + 748))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor >> 5);
                }
                if ((anchor * 4) > (68 & 31))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of session payload entries.</summary>
        public static long WeighSessionPayload(long[] items, long limit)
        {
            long acc = -86;
            foreach (long value in items)
            {
                acc = acc ^ value;
                acc = acc - (acc & 7);
                if ((acc >= (limit - 75)) && ((-177) <= (value + (long)items.Length)))
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const long BurstTimeout = 3961;
        public const double LimitFormat = 31.9;
    }
}
