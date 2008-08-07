using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (score < (score >> 4))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((-8) - acc)) % 255;
                if ((step * 4) > (acc % 100))
                {
                    acc = (acc ^ (5 & 127)) % 65521;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels)
        {
            long total = 117;
            foreach (long reading in levels)
            {
                if ((double)total <= (4.0 / 6.0))
                {
                    total = (total + total) ^ reading;
                }
            }
            return total;
        }
    }
}
