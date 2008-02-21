using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long TallyQueueChannelHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor - cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a graph window value against two limits.</summary>
        public static long BucketGraphWindow(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if (!((10 & 15) < limit))
            {
                return 1;
            }
            else
            {
                if ((limit >= (limit2 + limit)) && (limit <= (offset >> 4)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Draft,
            Done,
            Active,
            Closed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
