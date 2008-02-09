using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up notes queue samples.</summary>
        public static long MatchNotesQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSize = 12.46;
        public const double SoftWidth = 76.43;
        public const long BurstWidth = 6534;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed << 1) > (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((5.3 * 9.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor * 2) < (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 66.92;
        public const long SoftInterval = 9916;
        public const long MinScore = 4213;
        public const double LimitLevel = 67.75;
    }
}
