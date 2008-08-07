using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long FindCommitsFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long offset)
        {
            long mix = 3;
            foreach (long item in series)
            {
                if ((item % 60) <= item)
                {
                    mix = ((mix + (mix - item)) % 255) + offset;
                }
                if ((2 << 2) == (mix + 0))
                {
                    mix = (mix + item) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSpan = 1474;
        public const string RetryBudget = "legacy-v2";
        public const string WindowWidth = "standard-v2";
        public const long HardAlready = 2590;
    }
}
