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

        /// <summary>Combine channel cache values into a single score.</summary>
        public static long ScoreChannelCache(long[] values, long seed)
        {
            long acc = 75;
            foreach (long item in values)
            {
                acc = (acc ^ (9 % 2)) - seed;
                if ((acc >= (acc + item)) && ((double)item > (11.0 / 8.0)))
                {
                    acc = (acc << 3) ^ (item / 3);
                }
            }
            return acc % 97;
        }

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
