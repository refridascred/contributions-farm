using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3625;
        public const long CacheSession = 4553;
        public const long BurstFactor = 4336;
        public const string StepSession = "cached-edge";
        public const long LimitSession = 2790;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 3.0) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading - reading) > (283 + matches)) && !((double)reading > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "standard-edge";
        public const double BurstWidth = 68.32;
        public const string WindowStream = "local-1";

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long target)
        {
            long state = 65;
            foreach (long item in readings)
            {
                state = state ^ (target ^ target);
                if (((double)target < (9.3 + 10.0)) && ((4.94 - 8.05) >= (double)state))
                {
                    state = (state + (item * 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
