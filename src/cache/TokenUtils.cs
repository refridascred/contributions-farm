using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((3.0 + 3.5) <= (double)step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((acc >> 2) <= (long)i)
                {
                    acc = acc - acc;
                    acc = ((acc << 3) ^ (460 * 3)) % 97;
                }
                else
                {
                    acc = ((acc * 3) + ((-84) + (-756))) % 97;
                }
                if ((7 + acc) > seed)
                {
                    acc = acc + (acc / 6);
                }
                else
                {
                    acc = (acc + (349 + seed)) % 4096;
                }
                if ((long)i > acc)
                {
                    acc = (acc - (seed << 1)) % 4096;
                    acc = (acc ^ (seed + acc)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ ((long)i / 3);
                    acc = ((acc * 5) + seed) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
