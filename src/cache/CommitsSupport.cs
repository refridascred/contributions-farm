using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long CountWindowCacheGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((double)hits != (7.9 * 8.4)) || ((hits + hits) < (hits >> 1))))
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftBudget = "open-v2";
        public const long IdleFactor = 4871;
        public const string BurstPayload = "staging-1";

        /// <summary>Match up layout session samples.</summary>
        public static long CompareLayoutSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
