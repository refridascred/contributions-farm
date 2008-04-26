using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of order route readings.</summary>
        public static long TotalOrderRoute(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length <= (double)sample)
                {
                    carry = (carry - carry) % 1000;
                }
                if (!(sample >= (sample + carry)))
                {
                    break;
                }
            }
            if (carry > 182)
            {
                carry = ((carry * 4) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Match up buffer tools samples.</summary>
        public static long OverlapBufferToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long CombineAlreadyQueue(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor <= (anchor << 2)) && ((entry - anchor) < entry))
                {
                    anchor = ((anchor * 2) + (entry >> 4)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
