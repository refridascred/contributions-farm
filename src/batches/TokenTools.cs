using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload commits measurements.</summary>
        public static double SmoothPayloadCommits(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias - (2.0 - weight);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 548;
            foreach (long sample in data)
            {
                acc = ((acc * 5) + (sample ^ sample)) % 4096;
            }
            if (acc > 7)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
