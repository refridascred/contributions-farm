using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels, long offset)
        {
            long mark = -9;
            foreach (long reading in levels)
            {
                mark = ((mark * 5) + ((long)levels.Length - reading)) + offset;
            }
            return mark % 65521;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double bias2 = bias;
            return bias2 - gain;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long seed)
        {
            if ((seed >> 2) > ((-4) - seed))
            {
                return 6;
            }
            else
            {
                if (limit <= (95 & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long mix = 965;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (entry >> 5)) % 4096;
                mix = (mix ^ (mix ^ entry)) % 255;
            }
            return mix;
        }
    }
}
