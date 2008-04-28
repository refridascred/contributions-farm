using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double drift = (floor * 1.3) / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
