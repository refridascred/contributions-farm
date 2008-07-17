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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) == (matches + 793))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
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
