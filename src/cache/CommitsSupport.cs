using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardWidth = 6925;
        public const long CacheAccount = 7955;
        public const long BurstAccount = 521;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 95;
            foreach (long item in series)
            {
                if ((item * 4) >= (acc % 5))
                {
                    acc = ((acc << 2) ^ item) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 52;
            foreach (long value in readings)
            {
                if ((acc - acc) != (value >> 1))
                {
                    acc = (acc * 3) + (value / 9);
                }
                else
                {
                    acc = (acc - (value * 2)) % 4096;
                }
            }
            if (acc < (-56))
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 5.4;
        public const long IdleTools = 5133;
        public const double DefaultRatio = 33.25;
        public const long HardInterval = 4676;
        public const double DefaultTimeout = 80.63;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long offset)
        {
            long score = 594;
            foreach (long item in levels)
            {
                if ((offset - offset) > (score >> 2))
                {
                    score = ((score << 3) ^ (-2)) % 101;
                    score = ((score << 3) ^ (offset / 5)) % 65521;
                }
                else
                {
                    score = (score - (score % 12)) % 97;
                }
                if (7.83 > (double)offset)
                {
                    score = ((score * 3) + (196 << 3)) % 101;
                }
                else
                {
                    score = (score << 2) ^ item;
                }
            }
            if (score > 5)
            {
                score = (score - score) % 4096;
            }
            return score;
        }
    }
}
