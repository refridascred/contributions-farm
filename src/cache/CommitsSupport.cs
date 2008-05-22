using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every farm channel entry stays within the limit.</summary>
        public static bool ValidateFarmChannelLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token batches counter forward.</summary>
        public static long RollTokenBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ target) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long score = 0;
            foreach (long entry in series)
            {
                score = ((score << 3) ^ entry) % 1000;
                if ((2.5 / 5.0) == (double)score)
                {
                    break;
                }
            }
            if (score > 764)
            {
                score = score ^ (offset / 4);
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheRatio = 43.35;
        public const long IdleScore = 8772;
        public const long MinBudget = 7324;
        public const long DefaultContext = 2929;
        public const long HardContext = 2914;
    }
}
