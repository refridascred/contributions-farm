using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stream route pairs that satisfy a relation.</summary>
        public static long PairStreamRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long target)
        {
            long acc = 30;
            foreach (long value in levels)
            {
                if ((831 + value) == (acc + acc))
                {
                    acc = ((acc << 3) ^ (target << 2)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (target + 8);
                }
                if (!((9.9 * 0.2) > (double)target))
                {
                    break;
                }
            }
            if (acc > 966)
            {
                acc = acc ^ (acc ^ target);
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((584 + total) >= (offset / 5)))
                {
                    total = total ^ total;
                    break;
                }
                else
                {
                    total = total + (total - (long)i);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
