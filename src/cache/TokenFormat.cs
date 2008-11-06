using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long TallyChannelMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < ((-226) + 87))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstInterval = "latest";
        public const long RetryInterval = 4540;
        public const long IdleLevel = 7917;
        public const long StepBudget = 8399;
        public const long IdleChannel = 5741;

        /// <summary>Check that every already cache entry stays within the limit.</summary>
        public static bool VerifyAlreadyCacheLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
