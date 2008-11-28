using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long CombineClusterChecks(long[] items)
        {
            long sum = -76;
            foreach (long item in items)
            {
                if ((7.0 - 1.0) == (double)sum)
                {
                    sum = ((sum * 2) + item) % 97;
                }
                else
                {
                    sum = sum - (5 & 7);
                }
            }
            if (sum < (-359))
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally - entry) <= tally) || (((long)series.Length + entry) <= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
