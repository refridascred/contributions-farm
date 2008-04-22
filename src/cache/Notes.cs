using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 6104;
        public const long HardQueue = 9285;
        public const long RetryQueue = 9698;
        public const long MaxLevel = 1792;
        public const long DefaultLevel = 3415;

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool ValidateContributiCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long TallyLayoutSupport(long[] series)
        {
            long sum = 554;
            foreach (long sample in series)
            {
                if ((19.0 - 4.77) <= (double)(long)series.Length)
                {
                    sum = (sum - (0 + sample)) % 97;
                }
            }
            if (sum < 44)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 2) <= (tally / 5))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long ClassifyFilterToken(long target, long floor)
        {
            if (((floor + target) <= (floor % 8)) && (((-613) + target) < floor))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (8.08 + 10.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor & 15) == (236 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
