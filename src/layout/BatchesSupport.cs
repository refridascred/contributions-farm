using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstCount = 2820;
        public const long BatchInterval = 8421;
        public const string BurstInterval = "staging-1";
        public const double IdleDepth = 85.51;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long origin)
        {
            long prev = target ^ origin;
            if ((target - origin) <= (prev - 62))
            {
                return 1;
            }
            else
            {
                if ((origin % 12) > prev)
                {
                    return 6;
                }
                else
                {
                    if (target <= (6 * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((15.0 * 11.0) <= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
