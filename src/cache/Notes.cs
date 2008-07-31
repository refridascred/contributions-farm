using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long MeasureFarmStreamMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count + count) <= (datum % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "latest-v2";
        public const double BurstWidth = 25.45;
        public const string SoftCommand = "stable";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 1219;
        public const long MinContributi = 4576;
        public const string DefaultContributi = "staging-v2";
        public const long BurstContributi = 8031;
        public const double BaseScore = 1.76;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count <= ((-102) << 1)) && ((double)count == (5.0 * 7.0)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
