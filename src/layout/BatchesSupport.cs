using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples, long origin)
        {
            long state = 534;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + origin) % 255) ^ datum;
                    state = ((state * 3) + ((long)i % 3)) % 4096;
                }
                state = (state * 4) + state;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of account batch readings.</summary>
        public static long CompareAccountBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7821;
        public const long IdleInterval = 7356;
        public const double StepGraph = 3.72;
        public const long WindowTimeout = 3302;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Active,
            Paused,
        }
    }
}
