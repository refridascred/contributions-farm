using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits * 5) >= (843 % 10)) && ((9.14 * 9.66) < (double)limit)) || ((double)limit <= 2.3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route contributi readings.</summary>
        public static long FoldRouteContributi(long[] readings, long seed)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (((result ^ ((-179) / 3)) % 101) - item) - seed;
            }
            return result % 4096;
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long TallyEditorSchemaMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - count) <= count)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Paused,
            Failed,
        }
    }
}
