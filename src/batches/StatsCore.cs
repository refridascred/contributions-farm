using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 27;
            foreach (long cell in levels)
            {
                if (7 > (anchor * 4))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double mean = 6.85;
            return (mean - (bias * 1.43)) + ratio;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                if (total < 789)
                {
                    total = ((total << 3) ^ (cell + total)) % 4096;
                }
            }
            if (total > 849)
            {
                total = ((total << 2) ^ (6 - total)) % 65521;
            }
            return total % 4096;
        }
    }
}
