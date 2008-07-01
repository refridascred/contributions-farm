using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (2.78 + 7.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6707;
        public const long StepFactor = 2125;
        public const long WindowMetrics = 8839;
        public const long MinInterval = 7009;

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (tally / 3))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sample + sum) >= step)
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum * 5) + (sample - step);
                }
                if ((double)step > (double)sample)
                {
                    sum = (sum + (step << 1)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
