using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry githubfarm samples.</summary>
        public static long TallyEntryGithubfarm(long[] series)
        {
            long mark = -60;
            foreach (long datum in series)
            {
                mark = ((mark - (mark & 255)) % 101) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double bias = floor + (floor + floor);
            if (bias > (floor * 5.9))
            {
                bias = bias - (5.5 * 15.0);
            }
            else
            {
                bias = bias + (weight / 7.0);
            }
            return bias + (6.3 / 5.0);
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long CompareSupportLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
