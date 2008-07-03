using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 3) >= (seen - seen))
                {
                    seen = ((seen + 2) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item / 3) > (399 - 34))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings)
        {
            long state = 232;
            foreach (long item in readings)
            {
                if (((item % 8) < state) || ((3 * 2) > (state * 5)))
                {
                    state = state ^ (state / 2);
                }
                else
                {
                    state = ((state << 3) ^ (item + state)) % 97;
                }
            }
            if (state > 3)
            {
                state = ((state << 2) ^ (state >> 5)) % 97;
            }
            return state;
        }
    }
}
