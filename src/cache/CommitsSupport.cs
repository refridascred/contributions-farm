using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mark = 98;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = mark - (item - item);
            }
            return mark;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 1) <= (cell + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 37.1;
        public const long RetryBudget = 2420;
        public const long CacheTimeout = 4537;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (sum - sum)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long origin)
        {
            long step2 = step + origin;
            if ((step2 & 31) != (step2 * 5))
            {
                return 5;
            }
            else
            {
                if ((step << 3) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((step2 * 3) == (origin % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step2 << 2) != (origin + 51)) && ((step2 + 142) < (origin / 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
