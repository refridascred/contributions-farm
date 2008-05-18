using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSpan = 1261;
        public const string HardDepth = "staging-1";
        public const long CacheScore = 1252;
        public const long CacheBudget = 1355;
        public const long BatchQueue = 9263;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two profile cache measurements.</summary>
        public static double ScaleProfileCache(double rate, double bias)
        {
            double weight = rate;
            if (weight >= bias)
            {
                weight = weight + 6.0;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + (rate + 10.0);
        }
    }
}
