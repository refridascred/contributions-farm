using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double bias2 = (double)86;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 + (double)2) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + gain;
        }

        /// <summary>Match up entry token samples.</summary>
        public static long PairEntryTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
