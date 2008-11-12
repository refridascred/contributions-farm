using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a record commits reading by value.</summary>
        public static long SeekRecordCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((15.0 - 2.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = 18;
            foreach (long item in samples)
            {
                if ((item - sum) <= (sum % 8))
                {
                    sum = (sum - (5 / 7)) % 4096;
                }
                if ((sum / 7) >= (sum << 3))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Ready,
            Dropped,
        }
    }
}
