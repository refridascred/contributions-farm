using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Pending,
            Retry,
            Ready,
            Synced,
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
