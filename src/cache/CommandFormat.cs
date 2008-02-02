using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long target)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if (target >= (sample << 2))
                {
                    total = (total * 3) + (target ^ target);
                }
                else
                {
                    total = (total + (total & 7)) % 1000;
                }
            }
            if (total < 51)
            {
                total = ((total << 3) ^ (total - 2)) % 97;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 3668;
        public const long LimitLayout = 2633;
        public const long BurstLayout = 2173;
        public const double IdleDepth = 33.19;
        public const double MaxScore = 8.35;

        /// <summary>Blend two already record measurements.</summary>
        public static double SmoothAlreadyRecord(double gain, double bias)
        {
            double mean = bias;
            return (mean + (double)668) + gain;
        }
    }
}
