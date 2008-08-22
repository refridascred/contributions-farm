using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long CountNotesGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.0 - 8.16))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepDepth = 20.9;
        public const double LimitReport = 46.31;
        public const string BatchWidth = "strict";
    }
}
