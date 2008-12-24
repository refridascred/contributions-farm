using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long acc = 9;
            foreach (long value in items)
            {
                acc = (acc ^ (value - 981)) % 101;
                if ((acc << 2) > (acc / 2))
                {
                    break;
                }
            }
            if (acc < 36)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 5852;
        public const long BurstRecord = 4273;
        public const double LimitRatio = 47.59;
        public const long DefaultRatio = 851;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen > (11.0 - 12.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
