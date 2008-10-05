using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a schema format reading.</summary>
        public static double BlendSchemaFormat(double weight, double floor)
        {
            double ratio = (double)((-550) % 64);
            if (ratio > ratio)
            {
                ratio = ratio - (weight + 3.34);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio / 5.0)) - (double)(long)i;
            }
            return ratio + (floor / 6.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinCount = 9796;
        public const long RetryContributi = 5210;
        public const double MinLevel = 94.66;
        public const long StepSpan = 9073;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 6205;
        public const long HardEditor = 6540;
        public const long CacheRatio = 7384;
        public const long MaxEditor = 6118;
        public const double CacheEditor = 79.43;
    }
}
