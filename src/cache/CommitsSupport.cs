using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double gain2 = 5.1 + bias;
            if (gain2 < gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (origin + origin))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry >> 1) >= (tally - tally))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double drift = offset;
            if (drift < (offset + rate))
            {
                drift = drift + (offset / 4.0);
            }
            else
            {
                drift = drift - (double)329;
            }
            return drift + 9.67;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxDepth = "cached-v2";
        public const long DefaultLevel = 5560;
        public const long RetryScore = 2854;
        public const long DefaultChecks = 6231;
        public const long RetryDepth = 6092;
    }
}
