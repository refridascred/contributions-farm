using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetrySpan = 712;
        public const double HardChannel = 9.36;
        public const long BurstChannel = 9229;

        /// <summary>Count editor stream pairs that satisfy a relation.</summary>
        public static long PairEditorStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings, long offset)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if ((long)readings.Length <= (anchor - offset))
                {
                    anchor = ((anchor * 2) + offset) % 1000;
                    anchor = ((anchor << 3) ^ (cell - offset)) % 1000;
                }
                if (((offset << 2) < (cell << 1)) || (offset >= (cell >> 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
            }
            return anchor % 1000;
        }
    }
}
