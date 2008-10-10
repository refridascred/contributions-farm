using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 6780;
        public const long BasePayload = 3090;
        public const long MinPayload = 668;
        public const string RetryCount = "strict";
        public const long WindowDepth = 6456;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - span) + weight;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i == (acc - acc))
                {
                    acc = (acc ^ (896 - acc)) % 97;
                    continue;
                }
                else
                {
                    acc = acc + offset;
                    acc = (acc * 4) + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long state = 79;
            foreach (long item in series)
            {
                if (((item + target) > (target >> 2)) || ((state * 3) < (target & 15)))
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 4096;
        }
    }
}
