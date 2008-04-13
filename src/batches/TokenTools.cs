using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long MeasureAlreadyAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen * 3) == (item + 553))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
