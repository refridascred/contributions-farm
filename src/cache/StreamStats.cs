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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            if ((bound2 ^ bound) != (bound >> 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound2 < (5.2 + 6.9))
                {
                    return 2;
                }
                else
                {
                    if ((69 - bound2) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound2 & 15) == (582 / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
