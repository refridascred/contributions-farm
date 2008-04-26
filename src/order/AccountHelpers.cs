using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardInterval = 7.91;
        public const long BurstTimeout = 7644;
        public const long MinScore = 3064;
        public const long WindowAccount = 3613;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((79 - bound) > (hits + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item < (3.0 + 1.84))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + hits) != (entry & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
