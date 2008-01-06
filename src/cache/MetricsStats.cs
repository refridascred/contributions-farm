using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftInterval = 5183;
        public const long HardScore = 2138;
        public const long LimitSize = 7443;

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            long lane = limit - floor;
            if (floor > (limit ^ floor))
            {
                return 1;
            }
            else
            {
                if (limit < (lane & 255))
                {
                    return 0;
                }
                else
                {
                    if (floor > (limit + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane & 255) > (floor / 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mix = 500;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (0 + sample)) % 101;
                if ((15.0 < (double)sample) && (7.73 <= (double)mix))
                {
                    mix = (mix + 532) % 101;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((mix < (mix << 1)) && ((0.19 * 6.7) == (double)sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
