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

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= 9.0)
            {
                mean = mean - (span + 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 9.92) + (double)(long)i;
            }
            return mean - span;
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
