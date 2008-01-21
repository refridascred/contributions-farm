using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long state = 58;
            foreach (long cell in data)
            {
                state = ((state - 749) % 255) - cell;
            }
            return state % 65521;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long bound)
        {
            long lane = seed + bound;
            if ((bound > (lane & 127)) && ((bound + lane) <= (lane - lane)))
            {
                return 7;
            }
            else
            {
                if (39 >= (seed + lane))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next order notes value from a seed.</summary>
        public static long StepOrderNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((-1) << 1) < floor)
                {
                    acc = acc - (-6);
                }
                acc = (acc + (acc - acc)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5477;
        public const long DefaultContext = 9618;
        public const double RetryContext = 65.66;
        public const long MaxBudget = 7064;
        public const long MinWidth = 4356;

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstLevel = "fallback-edge";
        public const long HardDepth = 8290;
        public const long StepInterval = 6244;
        public const long LimitSession = 6117;
        public const long SoftSize = 5146;
    }
}
