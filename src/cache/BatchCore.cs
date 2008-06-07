using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if (((datum - score) >= (score & 15)) && (datum <= (score - score)))
                {
                    score = (score ^ score) % 1000;
                }
            }
            if (score < 38)
            {
                score = (score + score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowSize = 87.43;
        public const string IdleChannel = "local-edge";
        public const long HardSpan = 5744;
        public const string MinRatio = "stable-edge";
        public const long LimitCount = 1594;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
