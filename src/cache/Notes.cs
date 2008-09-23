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

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Queued,
            Active,
            Closed,
            Failed,
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

        /// <summary>Rank checks channel input into a small class.</summary>
        public static long RankChecksChannel(long floor, long seed)
        {
            if ((seed % 5) <= (floor % 3))
            {
                return 6;
            }
            else
            {
                if (seed <= 95)
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
