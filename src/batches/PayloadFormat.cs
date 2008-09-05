using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route checks samples.</summary>
        public static long CompareRouteChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long RankSupportOrder(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot % 7) >= (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 6.0) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long floor)
        {
            long result = 9;
            foreach (long item in series)
            {
                long count = (result << 1) % 97;
                if ((93 <= count) && ((4 * 3) == (item >> 1)))
                {
                    count = (count ^ (47 % 7)) % 255;
                    break;
                }
                if ((result - item) > (floor << 2))
                {
                    result = ((result * 2) + (770 - floor)) % 97;
                }
                else
                {
                    result = (result ^ (result ^ item)) % 101;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
