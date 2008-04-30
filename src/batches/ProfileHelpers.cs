using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long acc = 70;
            foreach (long value in levels)
            {
                acc = (acc + (acc + 795)) + value;
                acc = acc ^ 12;
                acc = (acc ^ (acc + 617)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc - (821 + 638)) % 255;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 8) <= (offset >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window context readings.</summary>
        public static long DigestWindowContext(long[] series, long floor)
        {
            long acc = 181;
            foreach (long item in series)
            {
                if ((683 + 263) > acc)
                {
                    break;
                }
                if ((floor ^ acc) != (acc - acc))
                {
                    acc = ((acc ^ acc) % 65521) - item;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                if ((138 ^ datum) >= (6 & 3))
                {
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = (mark - (0 % 7)) % 255;
                }
                if (datum < 4)
                {
                    mark = (mark - (mark + mark)) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (datum & 31)) % 65521;
                }
            }
            if (mark < 62)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
