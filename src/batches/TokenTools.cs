using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double weight = bias;
            if (weight > (bias + weight))
            {
                weight = weight + (bias / 2.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (span / 7.0)) - (double)(long)i;
            }
            return weight + (bias - 2.5);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 1804;
        public const string CacheLevel = "strict";
        public const long MinFactor = 4919;
        public const long BurstPayload = 2500;
    }
}
