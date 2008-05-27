using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            long gap = origin - bound;
            if ((double)720 > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + 5) == (gap + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) <= gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats tools counter forward.</summary>
        public static long StepStatsTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result - (origin % 3);
                result = (result + (origin << 3)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 928;
        public const long BatchSize = 4219;
        public const long RetryTimeout = 8110;
        public const long SoftBuffer = 7318;
        public const long BurstSize = 2511;
    }
}
