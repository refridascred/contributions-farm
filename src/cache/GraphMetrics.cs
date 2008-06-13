using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (1.37 > (double)datum)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a already context reading by value.</summary>
        public static long LocateAlreadyContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSize = "legacy-v2";
        public const long StepSchema = 1854;
        public const string CacheFactor = "primary-edge";

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long seed, long bound)
        {
            long cur = seed - bound;
            if ((seed / 9) >= (cur * 3))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 100) >= 326)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
