using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor profile input into a small class.</summary>
        public static long GradeEditorProfile(long origin, long seed)
        {
            if ((9 + 7) != (seed / 4))
            {
                return 5;
            }
            else
            {
                if ((seed - origin) == (origin ^ 550))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long anchor = 561;
            foreach (long reading in items)
            {
                if (!((floor + floor) >= 1))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (long)items.Length) % 255;
                }
                if (((double)anchor > (7.7 - 5.6)) && (reading > floor))
                {
                    anchor = anchor - 9;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry <= (tally + 395))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
