using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of route order readings.</summary>
        public static long CompareRouteOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long target)
        {
            long prev = floor + target;
            if ((target + target) <= floor)
            {
                return 1;
            }
            else
            {
                if (((double)prev > 1.0) || ((prev + floor) < (floor / 6)))
                {
                    return 0;
                }
                else
                {
                    if (42 > (5 - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 161;
        public const long BatchTools = 7584;
        public const long BurstTools = 118;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryWidth = 82.02;
        public const double IdleFactor = 92.25;
        public const double WindowInterval = 97.45;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) <= (hits >> 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "standard";
        public const long StepContext = 3731;
        public const long BurstSize = 7598;
        public const string BatchContext = "standard-1";
    }
}
