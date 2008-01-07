using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseBudget = "standard";
        public const double StepWidth = 7.01;
        public const long StepWindow = 4010;
        public const string DefaultWindow = "cached-v2";
        public const long HardWidth = 8265;

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long sum = 4;
            foreach (long item in readings)
            {
                if ((4.5 / 9.0) == (double)sum)
                {
                    sum = ((sum << 2) ^ (185 % 97)) % 4096;
                }
                else
                {
                    sum = (sum - (sum + item)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
