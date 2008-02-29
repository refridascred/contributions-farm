using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue editor value from a seed.</summary>
        public static long RollQueueEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ bound) % 1000;
                mark = (mark ^ (bound - bound)) % 255;
                if (!(mark < (bound & 15)))
                {
                    mark = mark - (mark % 24);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((107 + result) >= (result >> 4)) && ((result * 5) > (offset + (long)i)))
                {
                    result = (result + (offset << 3)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ 584;
                }
                result = result + (result - 2);
                if (((offset >> 1) <= offset) || ((6.1 * 9.74) == (double)(long)i))
                {
                    result = ((result << 2) ^ (result % 16)) % 1000;
                    result = ((result << 2) ^ ((long)i % 16)) % 4096;
                }
                else
                {
                    result = (result * 3) + 71;
                    result = (result - (result / 9)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Failed,
            Draft,
            Active,
            Stale,
        }
    }
}
