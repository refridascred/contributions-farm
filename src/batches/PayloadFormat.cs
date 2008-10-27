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

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 94.27;
        public const long SoftDepth = 7498;
        public const long BurstContext = 4467;

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
