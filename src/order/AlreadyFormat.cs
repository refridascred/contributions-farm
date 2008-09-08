using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSpan = "primary-v2";
        public const double RetrySchema = 80.52;
        public const long CacheLevel = 3310;
        public const long StepBudget = 5028;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long span = 27;
                if ((span >= ((long)i + acc)) && ((double)acc == (double)offset))
                {
                    acc = acc + ((-3) << 3);
                    span = (span * 2) + acc;
                }
                else
                {
                    span = ((span * 5) + offset) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((101 + target) != (seed - target))
            {
                return 8;
            }
            else
            {
                if ((115 % 7) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed % 8) == ((-763) >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long limit)
        {
            if ((limit % 16) <= (target + limit))
            {
                return 8;
            }
            else
            {
                if (limit >= (target >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (1.78 + 0.62))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((20.0 + 4.47) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long TotalGraphAlready(long[] readings, long limit)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = (carry * 3) + (carry - carry);
                if ((limit ^ cell) == (limit & 15))
                {
                    carry = (carry << 3) ^ limit;
                }
                if ((double)cell > (6.3 * 1.0))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 2) + ((long)readings.Length % 12);
            }
            return carry % 65521;
        }
    }
}
