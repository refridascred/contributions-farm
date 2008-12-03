using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5887;
        public const double LimitToken = 60.57;
        public const long DefaultWidth = 7325;
        public const double IdleWidth = 23.61;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values, long origin)
        {
            long mark = 3;
            foreach (long item in values)
            {
                if ((item + 691) >= item)
                {
                    mark = mark - item;
                }
            }
            if (mark < 527)
            {
                mark = (mark - (origin % 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
