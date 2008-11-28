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

        /// <summary>Define session limits and defaults.</summary>
        public const long StepDepth = 7537;
        public const long CacheSession = 6022;
        public const long WindowSession = 7173;

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5852;
        public const double WindowQueue = 80.67;
        public const string BatchQueue = "cached-1";
        public const long LimitQueue = 8786;

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
