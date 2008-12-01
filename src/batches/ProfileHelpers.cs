using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((floor % 64) >= 456)
                {
                    tally = (tally + 3) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (80 >= (limit + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up payload order samples.</summary>
        public static long OverlapPayloadOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9186;
        public const string MinEditor = "open-v2";
        public const long MinLevel = 8860;
        public const double StepFactor = 94.71;
        public const long SoftScore = 3286;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7605;
        public const string IdleEditor = "open";
        public const string BaseFactor = "primary-1";
        public const string BaseEditor = "cached";
    }
}
