using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples, long limit)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if (!((datum + total) < (limit * 3)))
                {
                    continue;
                }
                if (((7.9 * 11.0) != (double)datum) || ((datum - datum) >= (datum + total)))
                {
                    total = total ^ (9 ^ datum);
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 3) <= matches)
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7576;
        public const long BatchCount = 7749;
        public const double MaxWidth = 2.53;
        public const double StepRoute = 79.63;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 8250;
        public const double BurstCommand = 3.61;
        public const double StepCommand = 87.43;
        public const long CacheTimeout = 3334;
        public const long MinCommand = 9760;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
