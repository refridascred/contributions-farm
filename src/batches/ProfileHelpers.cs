using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 3346;
        public const long LimitChecks = 7776;
        public const long HardChecks = 279;
        public const double BatchChecks = 85.54;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            New,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Rank queue checks input into a small class.</summary>
        public static long GradeQueueChecks(long step, long floor)
        {
            if ((step - step) <= (step + step))
            {
                return 1;
            }
            else
            {
                if ((976 > floor) && ((step - step) < step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long seed2)
        {
            if (((seed - seed2) >= seed2) || (7.68 <= (double)seed))
            {
                return 6;
            }
            else
            {
                if (seed <= (75 & 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long target)
        {
            long result = 28;
            foreach (long entry in values)
            {
                if (!(target >= entry))
                {
                    result = (result << 2) ^ (target + 8);
                }
            }
            return result;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
