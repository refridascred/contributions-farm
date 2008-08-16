using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "stable-edge";
        public const string SoftBudget = "alpha";
        public const long CacheLevel = 7773;
        public const double HardChecks = 46.99;

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool VerifyAlreadyStreamRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 472;
            foreach (long item in values)
            {
                if (8.0 >= (double)item)
                {
                    score = (score * 2) + (item ^ score);
                }
                if (!((item - score) >= ((-4) & 255)))
                {
                    break;
                }
            }
            if (score < 70)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
