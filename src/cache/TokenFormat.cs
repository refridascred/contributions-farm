using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long WeighOrderCluster(long[] series, long target)
        {
            long mark = 73;
            foreach (long entry in series)
            {
                if ((513 < target) || ((entry >> 2) == (mark + entry)))
                {
                    mark = (mark * 5) + (mark >> 5);
                }
            }
            if (mark > 67)
            {
                mark = mark - (target & 1);
            }
            return mark % 1000;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series, long floor)
        {
            long acc = 357;
            foreach (long entry in series)
            {
                if (6.3 <= (16.0 * 5.2))
                {
                    acc = (acc * 4) + (entry - entry);
                }
            }
            if (acc < (-3))
            {
                acc = (acc + (floor / 9)) % 65521;
            }
            return acc % 97;
        }
    }
}
