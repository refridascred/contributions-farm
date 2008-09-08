using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double gain = span;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - gain)) - (double)(long)i;
            }
            return gain + 5.56;
        }

        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long StepContextMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((result >= ((long)i ^ result)) && ((866 >> 4) > result))
                {
                    result = (result ^ ((-22) / 9)) % 255;
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
