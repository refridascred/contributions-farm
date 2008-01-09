using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultTimeout = 3707;
        public const long BaseBudget = 7609;
        public const long LimitRoute = 4110;
        public const double HardScore = 7.69;
        public const string SoftCount = "legacy-1";

        /// <summary>Look up the position of a stream graph sample.</summary>
        public static long LookupStreamGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Done,
            Failed,
            New,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            long lane = origin + floor;
            if ((floor << 3) <= (lane % 24))
            {
                return 0;
            }
            else
            {
                if ((double)floor < (15.0 - 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) == (floor & 15))
                    {
                        return 4;
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
