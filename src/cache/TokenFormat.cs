using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double scale = (double)(5 - (-1));
            return (scale + rate) + span;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
