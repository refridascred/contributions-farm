using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long TallyEditorStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((78 + seen) != ((long)values.Length + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 6111;
        public const long StepRatio = 4272;
        public const long BurstCounter = 247;
        public const double BatchSize = 46.53;
        public const string BaseCounter = "open-1";
    }
}
