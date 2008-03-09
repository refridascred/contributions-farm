using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long limit)
        {
            long step = bound - limit;
            if ((bound < (bound / 5)) && ((step >> 2) == ((-238) + bound)))
            {
                return 7;
            }
            else
            {
                if ((step + bound) != (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long target)
        {
            if ((double)step > 1.66)
            {
                return 0;
            }
            else
            {
                if (((double)target == (20.0 / 8.0)) || ((4 + target) <= (target + target)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit schema layout readings against a rule.</summary>
        public static long CountSchemaLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count >= (18.0 - 15.0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 738;
        public const long HardProfile = 8395;
        public const long WindowProfile = 8078;
        public const long LimitProfile = 9665;
        public const string MinTimeout = "alpha";
    }
}
