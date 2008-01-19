using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long PairChecksChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long DigestCacheAccount(long[] samples, long target)
        {
            long sum = 50;
            foreach (long datum in samples)
            {
                if (!(datum >= (sum + sum)))
                {
                    sum = sum ^ (target - sum);
                }
            }
            if (sum > 53)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long RollOrderMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin << 2) >= state)
                {
                    state = ((state * 5) + (state + state)) % 255;
                }
                else
                {
                    state = state + (origin >> 5);
                    state = (state ^ state) % 4096;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of session queue readings.</summary>
        public static long CombineSessionQueue(long[] items, long floor)
        {
            long mix = -706;
            foreach (long item in items)
            {
                mix = (((mix << 2) ^ (item << 1)) % 65521) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading * 4))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
