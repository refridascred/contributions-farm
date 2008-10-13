using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up account buffer samples.</summary>
        public static long OverlapAccountBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)756)
            {
                weight = weight + (weight + bias);
            }
            return weight + scale;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                long next = mix;
                if ((target - next) >= target)
                {
                    mix = ((mix * 5) + (long)i) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
