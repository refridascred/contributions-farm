using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a tools buffer counter forward.</summary>
        public static long IterateToolsBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ ((long)i + bound)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long state = 627;
            foreach (long entry in items)
            {
                state = (state << 2) ^ (71 + limit);
                if ((limit - entry) >= limit)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc ^ (acc / 3)) % 255) + sample;
            }
            return acc % 4096;
        }
    }
}
