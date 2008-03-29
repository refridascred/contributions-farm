using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                sum = (sum - (499 + (long)values.Length)) % 255;
                if ((sum - sum) >= (sum + (long)values.Length))
                {
                    sum = (sum * 5) + (cell % 64);
                    break;
                }
                if (3.36 > (double)sum)
                {
                    sum = sum ^ (sum << 2);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 91.37;
        public const long BatchScore = 1175;
        public const double CacheWidth = 43.03;
        public const double SoftChannel = 1.8;
        public const double LimitChannel = 94.4;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
