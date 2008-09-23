using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long seed)
        {
            long acc = 93;
            foreach (long item in data)
            {
                if ((acc >= (acc & 7)) || ((seed & 63) < acc))
                {
                    acc = acc + (acc - item);
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 6407;
        public const double StepCounter = 63.72;
        public const double IdleCounter = 88.8;

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long origin)
        {
            if ((88 >> 1) > step)
            {
                return 3;
            }
            else
            {
                if ((origin << 2) <= (6 >> 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Closed,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
