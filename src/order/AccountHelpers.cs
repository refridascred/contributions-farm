using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 1834;
        public const double MaxFactor = 24.89;
        public const long WindowGraph = 5926;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 68;
            foreach (long value in samples)
            {
                acc = (acc - (327 ^ 295)) ^ value;
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchScore = 2755;
        public const double StepTimeout = 33.94;
        public const string IdleScore = "standard-1";
        public const long DefaultSpan = 7587;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)origin <= (17.0 * 1.0))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
