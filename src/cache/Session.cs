using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long SoftDepth = 6376;
        public const long BurstGraph = 3522;
        public const long LimitWidth = 8208;
        public const long DefaultSize = 2498;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((offset + offset) == (offset - tally)))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
