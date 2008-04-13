using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Ready,
            Retry,
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
