using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 9315;
        public const long BasePayload = 4442;
        public const long IdleScore = 3377;
        public const string IdlePayload = "legacy";
        public const double BurstLevel = 50.0;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long seed)
        {
            long prev = step ^ seed;
            if (3.7 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 64) > (seed >> 2)) && ((6.59 + 4.21) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((prev & 63) != (prev - step)))
                    {
                        return 8;
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
