using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long seed)
        {
            long sum = 758;
            foreach (long datum in levels)
            {
                sum = sum - (datum >> 1);
            }
            if (sum > 90)
            {
                sum = (sum - (seed - seed)) % 101;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftDepth = "primary";
        public const long RetryBudget = 9966;
        public const long SoftFactor = 2891;
        public const long IdleInterval = 4718;
        public const double BurstNotes = 93.95;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches >= (double)step)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
