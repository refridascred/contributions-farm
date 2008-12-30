using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin - 935) <= (total * 4)))
                {
                    total = (total + (355 - total)) % 97;
                }
                else
                {
                    total = (total + (total & 255)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 2537;
        public const long MaxBudget = 7548;
        public const long RetryLevel = 9985;
        public const double SoftGraph = 23.22;
        public const long BurstGraph = 6270;

        /// <summary>Audit editor format readings against a rule.</summary>
        public static long CountEditorFormatOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item <= (5.1 - 19.0))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            if ((1.0 * 2.31) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if (((419 - bound) < origin) && (33 >= (origin % 5)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 5) >= (5 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
