using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheCount = 5.51;
        public const double SoftLevel = 29.25;
        public const string BatchTimeout = "staging";
        public const long BaseContext = 5361;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score ^ 9)) % 101;
                score = (score - (score >> 2)) % 65521;
                if ((bound / 7) >= (8 - (long)i))
                {
                    score = (score << 2) ^ (bound - 63);
                    score = ((score * 5) + score) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
