using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank stream account input into a small class.</summary>
        public static long GradeStreamAccount(long bound, long offset)
        {
            long prev = bound + offset;
            if ((bound & 7) >= (prev / 6))
            {
                return 2;
            }
            else
            {
                if ((prev << 1) >= (5 - 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 3) <= (prev >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long step)
        {
            if (!((8.77 / 2.0) < (double)step))
            {
                return 8;
            }
            else
            {
                if ((target - target) < (8 * 4))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample <= (matches & 1))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((seen % 8) >= (seen + 17)) || ((2 - seen) <= (entry - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
