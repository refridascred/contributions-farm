using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long TallyProfileWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count / 9) <= (count + (long)readings.Length))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Queued,
            Ready,
            Locked,
        }
    }
}
