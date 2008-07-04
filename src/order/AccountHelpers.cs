using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((8.0 - 1.06) >= (double)bound)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(target <= (matches + item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > 20)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
