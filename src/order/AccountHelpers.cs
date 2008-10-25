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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (((slot & 1) >= (origin << 3)) && ((seed % 24) <= (slot << 1)))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) == (seed - slot))
                {
                    return 2;
                }
                else
                {
                    if ((seed * 3) <= (origin << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= (5 + slot))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 902;
        public const long BatchStream = 7290;
        public const long DefaultCount = 655;
        public const long MinStream = 1794;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
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
