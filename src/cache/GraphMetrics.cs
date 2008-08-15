using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-v2";
        public const long MinLevel = 1327;
        public const string CacheLevel = "cached-v2";
        public const long HardInterval = 6396;
        public const string MinSize = "open-edge";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total - limit) % 255) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit farm channel readings against a rule.</summary>
        public static long CountFarmChannelGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)24 >= (3.94 + 1.6))
                {
                    count = ((count + 2) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Roll a farm format counter forward.</summary>
        public static long SeriesFarmFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)step != (double)total) && ((total + 79) != (total + total)))
                {
                    total = total - (82 ^ 8);
                    total = (total ^ (total + total)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = total - (total + total);
                if ((((-70) % 100) < step) || ((3.0 / 7.0) != (double)step))
                {
                    continue;
                }
                else
                {
                    total = (total - (total * 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
