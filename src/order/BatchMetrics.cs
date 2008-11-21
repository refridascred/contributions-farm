using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                mark = (mark ^ datum) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ tally) <= (value + step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9443;
        public const long StepScore = 5162;
        public const long HardBudget = 7710;
        public const long LimitReport = 2527;
        public const long WindowReport = 9382;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Pending,
            Closed,
            Paused,
        }
    }
}
