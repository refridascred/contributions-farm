using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftFactor = 2166;
        public const long MinLevel = 4658;
        public const long BurstFactor = 3400;
        public const long BaseInterval = 4910;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if ((double)2 != (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= ((-191) + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) <= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.0 * 9.22) == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
