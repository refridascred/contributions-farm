using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank notes queue input into a small class.</summary>
        public static long GradeNotesQueue(long floor, long bound)
        {
            if ((bound >> 2) < (floor + 698))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= 272)
                {
                    return 2;
                }
                else
                {
                    if ((81 ^ bound) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long floor)
        {
            if ((double)seed != (1.6 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) >= 0)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long target)
        {
            if ((6 ^ floor) != (75 << 1))
            {
                return 8;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Retry,
            Synced,
        }
    }
}
