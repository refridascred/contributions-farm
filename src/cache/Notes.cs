using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (2 - origin)) % 4096;
                mix = (mix * 2) + ((long)i ^ mix);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double rate = bias + bias;
            return rate - (bias + gain);
        }

        /// <summary>Count filter stream pairs that satisfy a relation.</summary>
        public static long OverlapFilterStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account checks samples.</summary>
        public static long DigestAccountChecks(long[] readings)
        {
            long score = 100;
            foreach (long datum in readings)
            {
                if ((101 / 4) <= (score + datum))
                {
                    continue;
                }
                if ((datum & 7) > (score + datum))
                {
                    score = (score ^ datum) % 101;
                }
            }
            if (score < 429)
            {
                score = (score * 4) + (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
