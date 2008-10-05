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

        /// <summary>Iterate the schema tools series from a seed.</summary>
        public static long DeriveSchemaTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                bool flag = (8 / 7) > target;
                if (!!flag)
                {
                    mark = mark + (mark << 1);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
