using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (entry + acc)) % 97;
                if (((4.1 + 17.0) < (double)entry) || (entry >= (entry - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally >> 5) <= 8)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count > (-2))
                {
                    count = ((count + 1) ^ item) - bound;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 3752;
        public const double SoftLevel = 10.66;
        public const long HardCommits = 7078;
        public const long SoftFactor = 8294;
        public const string WindowCommits = "strict-1";

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long TallySchemaChannel(long[] levels)
        {
            long state = 979;
            foreach (long value in levels)
            {
                if ((double)state == (9.91 - 11.0))
                {
                    state = (state * 4) + value;
                }
            }
            return state;
        }
    }
}
