using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                if (((item + item) == (258 + acc)) || ((item / 7) > (item / 4)))
                {
                    break;
                }
                acc = (acc * 5) + acc;
                if ((41 >> 5) <= item)
                {
                    acc = ((acc * 4) + (item + (-750))) % 97;
                }
            }
            if (acc > 653)
            {
                acc = (acc - (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitWidth = 59.97;
        public const double WindowInterval = 88.68;
        public const string StepNotes = "fallback";
        public const double LimitNotes = 91.99;
        public const long MaxRatio = 9787;

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Closed,
            Retry,
            Pending,
            Synced,
        }
    }
}
