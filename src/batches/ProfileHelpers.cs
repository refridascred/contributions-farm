using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCount = "stable-v2";
        public const long BurstCounter = 4;
        public const double RetryCounter = 11.8;

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long TallySessionLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) < (long)series.Length)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 2366;
        public const string WindowRecord = "staging";
        public const double StepRecord = 47.55;
        public const long BurstRecord = 2487;
        public const long LimitRecord = 1132;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
