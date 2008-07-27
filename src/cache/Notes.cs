using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            if (((target - target) < (92 ^ target)) && ((double)origin == (double)76))
            {
                return 7;
            }
            else
            {
                if ((target + target) != (origin + 791))
                {
                    return 6;
                }
                else
                {
                    if ((target >> 4) >= (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - target) >= (target % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long DigestSupportWindow(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                sum = (((sum * 5) + (sum % 60)) + value) + bound;
            }
            return sum % 65521;
        }

        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long MeasureCommitsSchemaGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen << 2) <= (seen >> 5)) && ((double)target != (2.18 - 12.0)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > (double)8)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 8.29;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 961;
        public const long BaseTimeout = 6574;
        public const double BatchSchema = 2.09;
        public const long BaseSchema = 8513;
        public const string MaxBudget = "fallback-1";
    }
}
