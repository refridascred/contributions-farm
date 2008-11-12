using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stats payload entry that matches the target.</summary>
        public static long LocateStatsPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 625;
        public const double BurstSize = 95.16;
        public const long StepSupport = 1587;

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double scale2 = 3.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = (((scale2 + scale2) + (double)(long)i) - scale) - bias;
            }
            return scale2 - scale2;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
