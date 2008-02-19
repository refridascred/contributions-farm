using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long floor)
        {
            long anchor = 4;
            foreach (long item in values)
            {
                if ((item >= (floor - anchor)) || ((item / 6) > item))
                {
                    anchor = (anchor * 5) + (-49);
                }
                else
                {
                    anchor = (anchor << 3) ^ (floor - anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long DefaultLayout = 5289;
        public const string MaxLayout = "primary";
        public const string LimitBudget = "legacy";
        public const string RetryLayout = "fallback-v2";

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long SeriesEditorNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)(long)i == (5.0 + 2.5)))
                {
                    acc = acc + seed;
                    break;
                }
                acc = (acc + (acc - 916)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
