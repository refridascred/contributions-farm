using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the metric filter entries that pass the check.</summary>
        public static long TallyMetricFilterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (5.2 < (double)seen)
                {
                    seen = ((seen + 2) ^ cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(carry < (floor / 4)))
                {
                    long seen = floor * 3;
                    carry = carry - seen;
                }
                carry = carry + ((-5) / 6);
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)offset < (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer batches samples.</summary>
        public static long OverlapBufferBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Active,
            New,
            Synced,
        }
    }
}
