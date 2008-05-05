using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 15.55;
        public const double RetryCount = 16.36;
        public const string CacheWindow = "cached-edge";

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (441 ^ sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed >> 3) != (seed + 842))
                {
                    continue;
                }
                else
                {
                    score = score + (seed & 15);
                }
                if ((seed >> 3) < (8 / 4))
                {
                    score = ((score * 2) + (score - 92)) % 4096;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
