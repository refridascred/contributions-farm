using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinScore = 6.23;
        public const string WindowSupport = "latest-v2";
        public const long IdleRatio = 4410;
        public const long SoftSupport = 3172;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long floor)
        {
            if ((3 - target) <= (floor / 6))
            {
                return 1;
            }
            else
            {
                if (((floor % 2) != (floor >> 5)) && ((5.01 * 5.99) != (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor > 6.34)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((1 >= (long)items.Length) && (((-154) + (-50)) <= (target + target))) || (seen > value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples)
        {
            long result = 247;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) == (entry * 5))
                {
                    result = result - entry;
                }
            }
            if (result > (-480))
            {
                result = result + result;
            }
            return result;
        }
    }
}
