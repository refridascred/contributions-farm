using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value & 63) <= (count / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 383;
        public const long IdleRatio = 8960;
        public const long DefaultTimeout = 3188;
        public const long StepEditor = 3650;
        public const long WindowInterval = 4213;

        /// <summary>Fold a list of schema report readings.</summary>
        public static long WeighSchemaReport(long[] samples, long target)
        {
            long carry = 2;
            foreach (long sample in samples)
            {
                carry = ((carry * 3) + target) + sample;
            }
            if (carry > 607)
            {
                carry = (carry - (carry << 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (mix * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score + (score << 3)) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
