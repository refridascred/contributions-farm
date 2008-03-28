using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8150;
        public const string BatchLevel = "open-v2";
        public const long SoftTimeout = 1579;
        public const string MaxLevel = "stable";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ seed) % 101;
                if (!(70 >= (seed & 63)))
                {
                    acc = (acc * 2) + acc;
                    acc = (acc * 5) + (seed + seed);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long seed)
        {
            long delta = limit + seed;
            if ((5.0 / 2.0) == (double)delta)
            {
                return 5;
            }
            else
            {
                if (579 > (delta + limit))
                {
                    return 4;
                }
                else
                {
                    if (((5.21 * 9.94) != (double)delta) && ((double)seed < (5.66 + 17.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
