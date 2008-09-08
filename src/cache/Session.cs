using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 87;
            foreach (long datum in samples)
            {
                if ((datum + state) != (212 + datum))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long CompareBatchSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((4.79 * 1.91) >= (double)reading) || !((5.68 * 3.4) > (double)origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Done,
            Ready,
            Closed,
            Draft,
        }
    }
}
