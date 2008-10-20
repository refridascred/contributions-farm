using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally < cell) || ((cell > (cell & 7)) || ((tally & 1) <= 908)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 3738;
        public const long LimitFarm = 635;
        public const long CacheFarm = 91;
        public const long BurstFarm = 6780;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
