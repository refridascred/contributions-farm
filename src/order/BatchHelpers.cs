using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 2) ^ step;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next checks report value.</summary>
        public static double BlendChecksReport(double bias, double floor)
        {
            double drift = bias - (double)9;
            return (drift + (7.9 - drift)) + floor;
        }
    }
}
