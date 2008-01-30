using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitLevel = 20.48;
        public const string BurstFarm = "stable-edge";
        public const string RetryFarm = "stable";

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFactor = "cached-v2";
        public const double BaseFilter = 16.18;
        public const long MaxFilter = 8935;

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long score = 926;
            foreach (long value in levels)
            {
                score = (score + (score & 3)) ^ value;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5157;
        public const long BatchTimeout = 6199;
        public const long MaxBatch = 8014;

        /// <summary>Measure how many metrics batch samples are out of range.</summary>
        public static long AuditMetricsBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) <= ((-8) / 9))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
