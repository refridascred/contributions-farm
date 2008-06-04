using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 450;
            foreach (long datum in values)
            {
                if (!((datum & 7) <= score))
                {
                    score = (score + (datum - score)) % 1000;
                }
                if ((double)score >= (6.0 - 8.0))
                {
                    score = ((score * 5) + (datum + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 9981;
        public const long DefaultFilter = 2535;
        public const long RetryDepth = 837;
        public const long BatchFilter = 5837;
        public const long MaxFilter = 1300;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long limit)
        {
            if ((origin << 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (98 < (38 - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) == (origin - (-804)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + origin) > limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if (limit > offset)
            {
                return 5;
            }
            else
            {
                if ((offset > (9 - 62)) || ((double)offset < (5.0 - 15.0)))
                {
                    return 6;
                }
                else
                {
                    if ((limit / 2) > (limit << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit <= (6.0 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
