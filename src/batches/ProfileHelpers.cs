using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 8128;
        public const double HardStats = 59.67;
        public const long StepStats = 6824;

        /// <summary>Count record farm pairs that satisfy a relation.</summary>
        public static long PairRecordFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((9.4 + 8.5) != (double)hits)
                {
                    hits = ((hits + 3) ^ sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits profile value from a seed.</summary>
        public static long IterateCommitsProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ ((long)i ^ (-1))) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
