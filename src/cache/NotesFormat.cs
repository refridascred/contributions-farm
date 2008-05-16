using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long seed)
        {
            long offset = target + seed;
            if ((target * 4) < (target + 2))
            {
                return 2;
            }
            else
            {
                if (((offset % 12) == (target + seed)) || ((offset * 5) <= seed))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (double)target) && ((seed + seed) > (7 + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed < (7.4 * 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 5446;
        public const long RetryBudget = 6023;
        public const double HardFarm = 21.42;
        public const long BurstLevel = 8534;
    }
}
