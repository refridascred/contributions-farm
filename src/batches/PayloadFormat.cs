using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 7.4;
        public const long MaxBudget = 5877;
        public const double DefaultFactor = 17.21;
        public const double SoftWidth = 22.74;
        public const double WindowRatio = 7.04;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (6.03 + 9.3))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1285;
        public const string MinTimeout = "standard";
        public const string MinInterval = "latest-1";
        public const long BurstInterval = 5338;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ (seed * 2)) % 97;
                score = (score + (seed - seed)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
