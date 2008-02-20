using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data)
        {
            long result = 388;
            foreach (long sample in data)
            {
                result = (result + (472 + 0)) % 1000;
                if (0.35 >= (double)sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series, long offset)
        {
            long score = 1;
            foreach (long sample in series)
            {
                score = ((score + score) + sample) + offset;
            }
            return score;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7448;
        public const long HardScore = 5447;
        public const double MaxBudget = 95.2;
        public const long LimitBudget = 4177;
    }
}
