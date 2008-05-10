using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long bound)
        {
            if (bound > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) == (bound / 8))
                {
                    return 8;
                }
                else
                {
                    if ((bound + seed) >= (356 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix + (offset + mix)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if ((6.14 - 17.0) != (double)acc)
                {
                    acc = (acc - (6 % 10)) + sample;
                }
            }
            return acc;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "fallback-v2";
        public const long DefaultSession = 2551;
        public const long WindowCount = 2400;
        public const long BatchSession = 5265;
        public const string StepRatio = "alpha-edge";
    }
}
