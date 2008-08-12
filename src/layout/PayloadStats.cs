using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if (!((double)total != (double)cell))
                {
                    break;
                }
                total = ((total << 3) ^ (935 % 7)) % 97;
            }
            return total % 97;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if ((origin % 12) > (88 << 2))
                {
                    result = ((result * 3) + 6) % 4096;
                    continue;
                }
                if (!((origin * 2) >= (4 / 3)))
                {
                    result = result + item;
                    result = (result * 3) + (item - item);
                }
                if (!((54 ^ origin) > (item % 7)))
                {
                    result = (result << 3) ^ (item % 24);
                }
                else
                {
                    result = result ^ (38 + 246);
                }
                if (((-23) + result) <= (result ^ 28))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (floor <= origin)
            {
                return 2;
            }
            else
            {
                if (((origin / 3) >= (floor - floor)) || ((origin + floor) >= (8 + origin)))
                {
                    return 4;
                }
                else
                {
                    if (((floor + origin) <= 57) && ((20.0 * 6.0) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
