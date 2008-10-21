using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double drift = (double)(32 - 888);
            if (drift >= (ratio * 14.0))
            {
                drift = (drift - ratio) + floor;
            }
            else
            {
                drift = drift - 3.0;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
