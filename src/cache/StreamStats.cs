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

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] levels, long target)
        {
            long total = -230;
            foreach (long datum in levels)
            {
                total = (((total * 5) + (8 << 2)) % 65521) - datum;
                if ((double)target < (2.1 - 2.0))
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = total + (target - 656);
                }
            }
            if (total > 274)
            {
                total = ((total * 5) + (target + target)) % 97;
            }
            return total % 97;
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
