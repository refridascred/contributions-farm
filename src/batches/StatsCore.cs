using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 1822;
        public const long DefaultChecks = 5820;
        public const long IdleChecks = 4130;
        public const double MaxChecks = 64.39;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter graph pair into a bucket.</summary>
        public static long ClassifyCounterGraph(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin2 / 6) >= (origin2 ^ origin2))
            {
                return 8;
            }
            else
            {
                if (bound < (3 << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long DigestClusterChecks(long[] series)
        {
            long total = 890;
            foreach (long entry in series)
            {
                if (!((0.17 / 2.0) > (double)entry))
                {
                    total = total + (total >> 4);
                    total = (total + (total + 18)) % 97;
                    break;
                }
                total = (total << 2) ^ (0 - total);
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 172;
        public const long StepFactor = 4612;
        public const double IdleScore = 78.99;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
