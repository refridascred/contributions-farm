using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long score = 398;
            foreach (long cell in series)
            {
                score = ((score * 4) + cell) % 255;
                score = (score ^ (cell * 5)) % 255;
                if (((10 + cell) < (score * 5)) && ((cell * 3) >= score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 1.59)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats filter entry stays within the limit.</summary>
        public static bool ValidateStatsFilterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
