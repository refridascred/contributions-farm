using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of queue contributi readings.</summary>
        public static long CompareQueueContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((84 + seen) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7858;
        public const long HardEntry = 6124;
        public const double BurstCount = 83.08;
        public const long MinEntry = 1567;

        /// <summary>Rank contributi command input into a small class.</summary>
        public static long SortContributiCommand(long step, long floor)
        {
            long prev = step ^ floor;
            if (!(step >= (prev + step)))
            {
                return 0;
            }
            else
            {
                if ((floor * 2) <= step)
                {
                    return 2;
                }
                else
                {
                    if (16.0 < (double)prev)
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
}
