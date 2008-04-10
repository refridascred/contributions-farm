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

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i & 63) < (sum % 3)) || ((sum ^ floor) >= ((long)i / 2)))
                {
                    sum = ((sum << 3) ^ (8 >> 4)) % 4096;
                }
                sum = ((sum * 3) + ((long)i + floor)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
