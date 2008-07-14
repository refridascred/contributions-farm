using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Compare every pair of metrics context readings.</summary>
        public static long CompareMetricsContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support contributi entries.</summary>
        public static long TotalSupportContributi(long[] readings)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                total = (total ^ (629 * 4)) % 101;
                total = (total ^ (cell >> 5)) % 4096;
                if (!(31 < cell))
                {
                    total = ((total * 2) + total) % 65521;
                }
                if (!((cell << 1) < cell))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
