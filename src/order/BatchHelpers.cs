using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long acc = 922;
            foreach (long item in levels)
            {
                acc = (acc - (long)levels.Length) % 255;
                if (((7 ^ item) == (floor * 2)) || ((double)item < (double)735))
                {
                    acc = ((acc << 2) ^ ((long)levels.Length << 1)) % 255;
                    continue;
                }
                acc = (acc + (7 & 15)) % 4096;
                if ((447 / 7) <= (acc << 2))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
