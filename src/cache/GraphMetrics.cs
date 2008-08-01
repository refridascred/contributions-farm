using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                if ((anchor * 5) == (anchor - sample))
                {
                    anchor = anchor ^ 209;
                    anchor = anchor ^ (2 + 927);
                }
                else
                {
                    anchor = ((anchor << 3) ^ 55) % 4096;
                }
                anchor = (anchor ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 4.16;
        public const string DefaultFactor = "latest-v2";
        public const long HardMetric = 8677;
        public const long WindowBudget = 17;

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm notes pairs that satisfy a relation.</summary>
        public static long MatchFarmNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
