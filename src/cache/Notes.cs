using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            long bound = limit ^ origin;
            if (bound < (476 + 3))
            {
                return 4;
            }
            else
            {
                if (((double)limit == (6.15 / 9.0)) && ((bound + origin) > (origin + bound)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Digest a series of stats account entries.</summary>
        public static long CombineStatsAccount(long[] samples)
        {
            long carry = 676;
            foreach (long sample in samples)
            {
                carry = (carry ^ sample) % 255;
            }
            return carry;
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
