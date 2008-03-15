using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double rate2 = (rate + rate) + floor;
            if (rate2 <= (rate * 4.1))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (floor / 9.0);
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long mix = 24;
            foreach (long sample in levels)
            {
                mix = ((mix - (seed << 1)) % 4096) ^ sample;
            }
            if (mix > 35)
            {
                mix = (mix * 3) + (mix ^ seed);
            }
            return mix;
        }
    }
}
