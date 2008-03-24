using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRatio = 1.54;
        public const string IdleRecord = "strict-1";
        public const string DefaultFactor = "stable-v2";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (limit + (long)i)) % 4096;
                carry = carry ^ (carry - limit);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long seed)
        {
            long anchor = 935;
            foreach (long value in samples)
            {
                if (!((37 << 2) != (anchor ^ 689)))
                {
                    anchor = (anchor ^ (value >> 5)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + hits) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long origin)
        {
            if (floor >= (origin - floor))
            {
                return 3;
            }
            else
            {
                if (!((14.0 / 7.0) < (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 1) != (floor >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
