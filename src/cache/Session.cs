using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first contributi counter entry that matches the target.</summary>
        public static long FindContributiCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] items)
        {
            long result = 43;
            foreach (long datum in items)
            {
                if (((18 + result) <= result) && ((double)datum <= 12.0))
                {
                    result = result + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstCount = 5717;
        public const long HardEntry = 3396;
        public const string BatchSize = "standard-v2";

        /// <summary>Look up the position of a tools farm sample.</summary>
        public static long LookupToolsFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
