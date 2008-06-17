using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long seed)
        {
            if ((seed + (-47)) > (666 + 7))
            {
                return 8;
            }
            else
            {
                if ((offset <= (seed & 1)) && ((offset >> 1) != (seed << 2)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 95.28;
        public const double WindowCommand = 77.31;
        public const long CacheCommand = 931;
        public const double MinFactor = 12.9;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Stale,
            Paused,
            New,
            Done,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double rate = offset;
            if (rate < rate)
            {
                rate = (rate + (double)7) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - 12.0;
        }
    }
}
