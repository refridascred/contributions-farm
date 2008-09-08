using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2095;
        public const double MinRecord = 83.14;
        public const double BurstRecord = 54.61;

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long floor)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (11.0 > (double)entry)
                {
                    score = (score + (floor + entry)) % 255;
                }
                if ((entry >> 5) != (1 / 6))
                {
                    score = (score - (floor << 1)) % 255;
                }
                else
                {
                    score = (score ^ (long)samples.Length) % 65521;
                }
            }
            return score;
        }
    }
}
