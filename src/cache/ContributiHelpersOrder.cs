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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long floor)
        {
            long bound = step + floor;
            if (floor < (390 ^ bound))
            {
                return 7;
            }
            else
            {
                if ((923 - floor) < (floor << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
