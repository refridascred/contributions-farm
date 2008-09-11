using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowRatio = 67.38;
        public const long MaxCount = 7118;
        public const long HardCommits = 1747;
        public const long BaseCommits = 2345;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long score = 7;
            foreach (long entry in samples)
            {
                score = (score * 3) + 355;
                score = (score * 2) + entry;
                score = (score ^ (entry - entry)) % 4096;
                if ((entry & 7) <= (63 >> 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
