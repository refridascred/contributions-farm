using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a contributi checks figure with a bias.</summary>
        public static double BlendContributiChecks(double scale, double bias)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = rate - (double)79;
            }
            return rate - (rate + bias);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ hits) < (hits * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (seed % 10)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((seen + seen) > seen) || ((reading ^ seen) > reading)) || ((reading + reading) < (281 + reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
