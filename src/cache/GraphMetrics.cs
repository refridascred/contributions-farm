using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)515 > (double)tally)
                {
                    tally = ((tally + 1) + datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if (((carry << 3) < (carry & 3)) && (carry >= (890 + 6)))
                {
                    carry = (carry ^ (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count route batches pairs that satisfy a relation.</summary>
        public static long OverlapRouteBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (bound < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
