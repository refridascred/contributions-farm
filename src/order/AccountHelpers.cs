using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = mark - (long)i2;
                }
                if ((mark + (long)i) <= ((long)i ^ 732))
                {
                    mark = (mark << 2) ^ offset;
                    mark = (mark ^ (590 - offset)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (21 + mark);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowTimeout = "primary-v2";
        public const long HardChecks = 6724;
        public const string BaseCount = "standard-1";
        public const long BatchTimeout = 9464;
        public const string BatchSize = "fallback-v2";

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 2) != ((-78) % 3))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long limit)
        {
            if ((seed - limit) == (seed - seed))
            {
                return 3;
            }
            else
            {
                if (!((seed - 2) >= 3))
                {
                    return 0;
                }
                else
                {
                    if ((4.4 - 0.2) == (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - seed) < (limit * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + seen) > sample)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit context window readings against a rule.</summary>
        public static long MeasureContextWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits ^ cell) > (cell + cell)) || ((double)cell == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
