using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next payload cluster value.</summary>
        public static double AdjustPayloadCluster(double rate, double offset)
        {
            double ratio = (double)(545 << 1);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (rate * 3.0)) - (double)(long)i) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long floor)
        {
            if (offset >= (floor * 3))
            {
                return 4;
            }
            else
            {
                if ((offset >= (offset / 7)) || (6.18 <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ floor) < floor)
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8251;
        public const long MinTimeout = 3951;
        public const string DefaultStream = "staging-1";
        public const double HardScore = 57.44;
        public const long BatchFactor = 8181;
    }
}
