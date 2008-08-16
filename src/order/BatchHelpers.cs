using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 85;
            foreach (long reading in readings)
            {
                if ((923 - state) > (reading % 24))
                {
                    state = (state << 2) ^ state;
                }
                if (!((double)reading >= 8.0))
                {
                    state = (state << 3) ^ (state + reading);
                }
                else
                {
                    state = (state * 5) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double drift = (offset + scale) * 2.24;
            return drift + (drift - scale);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
