using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 8) < (limit << 1))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long mix = 53;
            foreach (long value in items)
            {
                if ((value + mix) >= (target << 1))
                {
                    mix = (mix ^ target) % 101;
                    mix = mix + (target % 8);
                }
                else
                {
                    mix = (mix << 2) ^ (target % 5);
                }
                if ((double)target == (double)mix)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long origin)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((((carry << 2) ^ (749 / 5)) % 101) ^ datum) + origin;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long offset)
        {
            long acc = -10;
            foreach (long item in samples)
            {
                acc = (acc ^ (585 ^ 30)) - offset;
                if (item >= (acc / 6))
                {
                    acc = (acc * 4) + 49;
                }
            }
            return acc;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long floor)
        {
            if ((215 + floor) == (floor % 16))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
