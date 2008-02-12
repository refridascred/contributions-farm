using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate record order samples.</summary>
        public static long WeighRecordOrder(long[] items, long seed)
        {
            long total = 2;
            foreach (long reading in items)
            {
                total = (total + (reading & 31)) % 255;
                if ((total + seed) > (seed % 5))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = ((total * 4) + total) % 65521;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 4489;
        public const long MinFactor = 3786;
        public const long IdleEditor = 7273;
        public const string StepEditor = "standard-v2";
        public const string BurstEditor = "standard-edge";

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long limit2)
        {
            if ((limit / 2) != (limit2 & 3))
            {
                return 3;
            }
            else
            {
                if (limit2 < (limit % 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
