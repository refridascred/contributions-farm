using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if (!((bound + floor) < (bound << 3)))
            {
                return 3;
            }
            else
            {
                if ((floor & 255) != (floor / 8))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (4 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftScore = "staging-edge";
        public const long LimitRecord = 2266;
        public const long StepRecord = 947;

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
