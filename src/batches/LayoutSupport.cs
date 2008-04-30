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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) <= count)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
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

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long CountLayoutChannelGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((step + cell) < (step + step)) && (tally < (cell * 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
