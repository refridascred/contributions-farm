using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools cache samples.</summary>
        public static long ScoreToolsCache(long[] data)
        {
            long state = 505;
            foreach (long sample in data)
            {
                state = ((state * 4) + (state << 1)) % 1000;
                state = state - (39 + sample);
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryBudget = 2140;
        public const double IdleSchema = 26.49;
        public const double IdleScore = 96.07;
        public const string LimitInterval = "fallback";
        public const long MinSchema = 7067;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6422;
        public const long BurstDepth = 9198;
        public const long BurstWidth = 3626;
        public const long HardTimeout = 163;
    }
}
