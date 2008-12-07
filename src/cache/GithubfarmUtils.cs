using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long acc = 51;
            foreach (long cell in levels)
            {
                if (58 >= (step & 63))
                {
                    acc = ((acc ^ acc) % 4096) + cell;
                }
            }
            if (acc < 0)
            {
                acc = acc - (step + step);
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 7726;
        public const long IdleFactor = 663;
        public const string BatchEditor = "cached";
        public const string WindowEditor = "standard-1";

        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long CountQueueBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry ^ entry) <= (matches + 89)) || ((matches / 4) < (26 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
