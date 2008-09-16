using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (origin + origin)) % 4096;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long step)
        {
            long score = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 3) + (entry % 7)) % 255;
                    score = ((score << 2) ^ ((long)i / 9)) % 1000;
                }
                score = (score - (62 - score)) % 97;
                if ((double)entry < (double)score)
                {
                    score = (score << 3) ^ (step ^ step);
                }
                else
                {
                    score = ((score << 2) ^ (score * 3)) % 101;
                }
            }
            return score;
        }
    }
}
