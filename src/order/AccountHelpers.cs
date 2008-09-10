using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= (4.0 + 8.6))
                {
                    count = ((count + 1) - item) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate order cluster samples.</summary>
        public static long CombineOrderCluster(long[] levels)
        {
            long state = 64;
            foreach (long entry in levels)
            {
                if (state < (entry * 5))
                {
                    state = (state + (752 + entry)) % 97;
                }
            }
            if (state > 38)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value >= count) && ((double)limit >= (0.7 + 7.4))) && ((limit * 4) > (limit + limit)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
