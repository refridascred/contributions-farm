using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count route cache pairs that satisfy a relation.</summary>
        public static long OverlapRouteCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)3) + (double)(long)i;
            }
            return bias - (span + bias);
        }
    }
}
