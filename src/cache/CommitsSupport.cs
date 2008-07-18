using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double weight = offset + (offset + ratio);
            if (weight <= 3.5)
            {
                weight = weight - (ratio + ratio);
            }
            return weight + weight;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 4920;
        public const long MaxDepth = 7537;
        public const long LimitTimeout = 7916;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxCount = 7421;
        public const string StepGraph = "strict-1";
        public const long LimitGraph = 9342;

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 65.07;
        public const string DefaultDepth = "stable-1";
        public const long BatchStream = 9557;
        public const long BaseStream = 4712;
        public const long BatchFactor = 928;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed + seed) == (offset2 & 1))
            {
                return 4;
            }
            else
            {
                if ((seed + offset) < (offset2 - offset2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
