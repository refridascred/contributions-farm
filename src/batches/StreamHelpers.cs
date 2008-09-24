using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long limit)
        {
            long edge = offset + limit;
            if (((offset - limit) > (limit ^ 17)) && ((1.0 * 12.0) == (double)limit))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((edge - edge) != (offset + 18))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit * 3) <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (710 >= (item + item))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter batch readings.</summary>
        public static long MatchFilterBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Dropped,
            Active,
        }
    }
}
