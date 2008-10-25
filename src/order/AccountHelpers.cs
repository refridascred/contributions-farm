using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long score = 251;
            foreach (long cell in levels)
            {
                score = (score ^ (cell & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((-708) - 938) > hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((20.0 - 17.0) != (double)cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 2552;
        public const double MinBudget = 19.85;
        public const long DefaultGraph = 2164;
        public const long SoftLevel = 1644;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long RankContextMetrics(long bound, long offset)
        {
            if ((bound + 270) <= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((double)offset < (8.3 + 7.0)) || ((0.4 + 8.7) < (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
