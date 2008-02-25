using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((limit - limit) > (seed & 15))
            {
                return 3;
            }
            else
            {
                if (seed <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 3499;
        public const long RetryProfile = 2078;
        public const long BurstWidth = 4234;
        public const double RetrySize = 21.55;
        public const long HardLevel = 5969;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Paused,
            Pending,
        }
    }
}
