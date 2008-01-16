using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) != (hits << 3))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (((acc + (long)i) >= ((long)i % 10)) || ((long)i > acc))
                {
                    acc = (acc - (acc + 25)) % 65521;
                    acc = acc - (acc >> 1);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowInterval = "cached-edge";
        public const long LimitContributi = 8674;
        public const string HardBudget = "cached";
    }
}
