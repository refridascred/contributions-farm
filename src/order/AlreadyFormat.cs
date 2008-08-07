using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of batch stream readings.</summary>
        public static long MatchBatchStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Failed,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long DigestLayoutReport(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                if (((435 << 1) <= state) && (606 > sample))
                {
                    state = state ^ (state ^ state);
                }
            }
            if (state > 44)
            {
                state = state ^ (state * 4);
            }
            return state % 65521;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Paused,
            Ready,
        }
    }
}
