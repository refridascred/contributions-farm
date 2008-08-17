using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if ((total ^ (-59)) == (total * 5))
                {
                    total = (total - (target + 919)) + sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Total { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 8;
            foreach (long entry in readings)
            {
                result = (((result << 2) ^ result) % 97) - entry;
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long CountWindowBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) != (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
