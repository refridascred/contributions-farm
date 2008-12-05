using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long TallyFilterGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)(long)values.Length < (0.74 + 4.3)) || ((12.0 * 6.55) <= (double)datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
