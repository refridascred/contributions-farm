using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (226 << 3))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window layout readings.</summary>
        public static long CombineWindowLayout(long[] data, long seed)
        {
            long state = 61;
            foreach (long reading in data)
            {
                state = ((state * 3) + (state << 3)) + reading;
            }
            if (state < (-933))
            {
                state = (state ^ (seed * 3)) % 65521;
            }
            return state;
        }

        /// <summary>Count metrics batch pairs that satisfy a relation.</summary>
        public static long MatchMetricsBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
